using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using static SitioReservaPeliculas.Modelos.ReservaDB;


namespace SitioReservaPeliculas.UI
{
    public partial class PrincipalUsuario : System.Web.UI.Page
    {
        private static ServiceReference_Reserva.ReservaSoapClient reserva = new ServiceReference_Reserva.ReservaSoapClient();
        private static ServiceReference_Cliente.ClienteSoapClient cliente = new ServiceReference_Cliente.ClienteSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid(); // Carga los datos en el GridView si no es una solicitud de envío.
                MostrarPrecioTotalReservas(); //NicoPagoTotal
            }
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetNoStore();


        }
        private void CargarGrid()
        {
            String jsonResult = reserva.TraerReserva(Session["ClienteLogeado"].ToString()); // Obtiene datos de reservas en formato JSON.
            List<Reserva> reservaL = JsonConvert.DeserializeObject<List<Reserva>>(jsonResult); // Deserializa los datos JSON.
            GridView_Reservas.DataSource = reservaL; // Asigna los datos al GridView.
            GridView_Reservas.DataBind(); // Enlaza y muestra los datos en el GridView.
        }

        [WebMethod]
        public static string EliminarFila(int id)
        {
            int rowId = id;
            String mensaje = reserva.eliminarReserva(rowId); // Llama al método del servicio web para eliminar una reserva.
            return "success"; // Retorna "success" o "error" en caso de fallo.
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            // Deshabilitar la caché y limpiar cookies y sesiones al cerrar sesión.
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetNoStore();

            Response.Cookies.Clear();
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Session.Remove("ClienteLogeado");

            // Redirigir a la página de inicio de sesión después de cerrar sesión.
            Response.Redirect("InicioReservaPelicula.aspx");
        }
        private string ListarCliente()
        {
            string nombreCliente = "";

            if (Session["ClienteLogeado"] != null)
            {
                String jsonResult = cliente.mostrarCliente(Session["ClienteLogeado"].ToString());
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);
                dt.Columns.Add("nombre_completo", typeof(string), "nombre + ' ' + apellido");

                // Obtener el nombre del cliente del DataTable
                nombreCliente = dt.Rows[0]["nombre_completo"].ToString();
            }

            return nombreCliente;
        }

        protected string GetNombreCliente(object idCliente)
        {
            // Llama al método ListarCliente para obtener el nombre del cliente
            // Aquí deberías tener acceso al método ListarCliente definido en tu archivo .aspx.cs
            // Asigna el valor del idCliente a la variable de clase
            Session["ClienteLogeado"] = idCliente;

            string nombreCliente = ListarCliente();

            return nombreCliente;
        }

        private void MostrarPrecioTotalReservas() // NicoPagoTotal
        {
            // Asegúrate de tener acceso a la sesión y de que contenga el usuario logeado
            if (Session["ClienteLogeado"] != null)
            {
                // Obtén el valor de idCliente de la sesión y conviértelo a int
                int t = Convert.ToInt32(Session["ClienteLogeado"]);

                // Calcula el precio total de las reservas para el usuario y asigna el valor al label
                decimal precioTotal = reserva.CalcularPrecioTotal(t); // Aquí deberías proporcionar el ID del cliente
                lblPrecioTotal.Text = precioTotal.ToString("C");
            }
            else
            {
                // Maneja el caso en el que no haya usuario logeado en la sesión
                lblPrecioTotal.Text = "Inicie sesión para ver el precio total de las reservas.";
            }
        }

        public string ObtenerNombrePelicula(object idPelicula)
        {
            if (idPelicula != null)
            {
                int peliculaId = Convert.ToInt32(idPelicula);

                // Llamar al método del servicio web para obtener el nombre de la película
                // Asegúrate de reemplazar 'reserva' con la instancia correcta de tu servicio web
                string nombrePelicula = reserva.ObtenerNombrePelicula(peliculaId);

                return nombrePelicula;
            }
            else
            {
                return string.Empty;
            }
        }

    }
}