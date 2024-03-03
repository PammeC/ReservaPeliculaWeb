using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SitioReservaPeliculas.UI
{
    public partial class RegistroReservas : System.Web.UI.Page
    {
        private static ServiceReference_Reserva.ReservaSoapClient reserva = new ServiceReference_Reserva.ReservaSoapClient();
        private static ServiceReference_Cliente.ClienteSoapClient cliente = new ServiceReference_Cliente.ClienteSoapClient();

        // Propiedades para mostrar alertas y mensajes de información en la página
        public bool Alerta { get; set; } = false;
        public bool Info { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetNoStore();

            // Verificar si hay una sesión de usuario activa.
            if (Session["UsuarioLogeado"] != null || Session["ClienteLogeado"] != null)
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
            if (!IsPostBack)
            {
                // Llamar a las funciones para cargar la lista de clientes y peliculas
                ListarCliente();
                ListarPelicula();
                DataBind();
            }
        }

        protected void Button_Registrar_Click(object sender, EventArgs e)
        {
            String mensajeR = "";
            String selectedDate = datePicker.Text;
            String selectedTime = timePicker.Value;

            if (Convert.ToInt32(DropDownList_Cliente.SelectedValue) != 0 && selectedDate != "" && selectedTime != "" && Convert.ToInt32(DropDownList_Pelicula.SelectedValue) != 0)
            {
                // Llamar a la función para registrar la reserva
                if (Session["ClienteLogeado"] != null)
                {
                    mensajeR = reserva.registrarReserva(Convert.ToInt32(Session["ClienteLogeado"]), selectedDate, selectedTime, Convert.ToInt32(DropDownList_Pelicula.SelectedValue));
                }
                else
                {
                    mensajeR = reserva.registrarReserva(Convert.ToInt32(DropDownList_Cliente.SelectedValue), selectedDate, selectedTime, Convert.ToInt32(DropDownList_Pelicula.SelectedValue));
                }

                // Mostrar mensaje de éxito
                Label_Info.Text = mensajeR;
                DropDownList_Cliente.SelectedIndex = 0;
                datePicker.Text = "";
                timePicker.Value = "";
                DropDownList_Pelicula.SelectedIndex = 0;
                Alerta = false;
                Info = true;
                DataBind();
            }
            else
            {
                // Mostrar mensaje de alerta si los campos no están llenos
                mensajeR = "Es necesario que llene todos los campos";
                Label_Alerta.Text = mensajeR;
                Alerta = true;
                DataBind();
            }
        }

        private void ListarCliente()
        {
            if (Session["ClienteLogeado"] != null)
            {
                String jsonResult = cliente.mostrarCliente(Session["ClienteLogeado"].ToString());
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);
                dt.Columns.Add("nombre_completo", typeof(string), "nombre + ' ' + apellido");

                DropDownList_Cliente.DataSource = dt;
                DropDownList_Cliente.DataTextField = "nombre_completo";
                DropDownList_Cliente.DataValueField = "id";
                DropDownList_Cliente.SelectedIndex = 1;
                DropDownList_Cliente.DataBind();
                DropDownList_Cliente.Enabled = false;
            }
            else
            {
                // Obtener la lista de clientes desde el servicio web y cargarla en el DropDownList_Cliente
                String jsonResult = reserva.listarClientes();
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);

                DataRow defaultRow = dt.NewRow();
                defaultRow["id"] = 0; // Valor en blanco o null para el valor por defecto
                defaultRow["nombre"] = "Seleccione Cliente"; // Texto del valor por defecto
                dt.Rows.InsertAt(defaultRow, 0);

                dt.Columns.Add("nombre_completo", typeof(string), "nombre + ' ' + apellido");

                DropDownList_Cliente.DataSource = dt;
                DropDownList_Cliente.DataTextField = "nombre_completo";
                DropDownList_Cliente.DataValueField = "id";
                DropDownList_Cliente.DataBind();
            }
        }

        private void ListarPelicula()
        {
            // Obtener la lista de películas desde el servicio web y cargarla en el DropDownList_Pelicula
            String jsonResult = reserva.listarPeliculas();
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);

            // Asegurarse de que la DataTable no sea nula y tenga al menos una fila
            if (dt != null && dt.Rows.Count > 0)
            {
                DropDownList_Pelicula.DataSource = dt;
                DropDownList_Pelicula.DataTextField = "nombre";
                DropDownList_Pelicula.DataValueField = "id";
                DropDownList_Pelicula.DataBind();
            }
        }


    }
}
