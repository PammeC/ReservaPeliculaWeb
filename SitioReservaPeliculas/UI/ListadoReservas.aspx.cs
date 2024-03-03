using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using static SitioReservaPeliculas.Modelos.ReservaDB;

namespace SitioReservaPeliculas.UI
{
    public partial class ListadoReservas : System.Web.UI.Page
    {
        private static ServiceReference_Reserva.ReservaSoapClient reserva = new ServiceReference_Reserva.ReservaSoapClient();
        // Creación de un cliente para el servicio web de reservas.

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid(); // Carga los datos en el GridView si no es una solicitud de envío.
            }
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetNoStore();

            // Verificar si hay una sesión de usuario activa.
            if (Session["UsuarioLogeado"] != null)
            {
                // El usuario está autenticado y la sesión es válida.
                // Puedes realizar acciones específicas para el usuario autenticado aquí.
                // En este espacio del condicional, puedes agregar código para realizar acciones
                // que solo deberían ejecutarse cuando el usuario está autenticado como administrador.
            }
            else
            {
                // Si no hay una sesión de usuario autenticado, redirigir a la página de inicio de sesión.
                Response.Redirect("InicioSesion.aspx");
            }
        }

        protected void GridView_Reservas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView_Reservas.EditIndex = -1; // Salir del modo de edición.
            CargarGrid(); // Recarga los datos en el GridView.
            Response.Redirect(Request.Url.AbsoluteUri); // Redirige a la misma página.
        }

        protected void GridView_Reservas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView_Reservas.EditIndex = e.NewEditIndex; // Cambiar a modo de edición.
            CargarGrid(); // Recarga los datos en el GridView.
        }

        protected void GridView_Reservas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowId = Convert.ToInt32(GridView_Reservas.DataKeys[e.RowIndex]["id"]);
            GridViewRow row = GridView_Reservas.Rows[e.RowIndex];
            String cliente = (row.FindControl("TextBoxCliente") as TextBox).Text;
            String fecha = (row.FindControl("TextBoxFecha") as TextBox).Text;
            String hora = (row.FindControl("TextBoxHora") as TextBox).Text;
            String pelicula = (row.FindControl("TextBoxPelicula") as TextBox).Text;
            String mensaje = reserva.modificarReserva(rowId, int.Parse(cliente), fecha, hora, int.Parse(pelicula));
            CargarGrid(); // Recarga los datos en el GridView.
            Response.Redirect(Request.Url.AbsoluteUri); // Redirige a la misma página.
        }

        private void CargarGrid()
        {
            String jsonResult = reserva.TraerReserva(""); // Obtiene datos de reservas en formato JSON.
            List<Reserva> reservaL = JsonConvert.DeserializeObject<List<Reserva>>(jsonResult); // Deserializa los datos JSON.
            GridView_Reservas.DataSource = reservaL; // Asigna los datos al GridView.
            GridView_Reservas.DataBind(); // Enlaza y muestra los datos en el GridView.
        }

        [WebMethod]
        public static string EliminarFila(int id)
        {
            int rowId = id;
            String mensaje = reserva.eliminarReserva(rowId); // Llama al método del servicio web para eliminar una reserva.
            return mensaje; // Retorna "success" o "error" en caso de fallo.
        }
    }
}
