using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using SitioReservaPeliculas.Modelos;
using static SitioReservaPeliculas.Modelos.ClienteDB;


namespace SitioReservaPeliculas.UI
{
    public partial class ListadoClientes : System.Web.UI.Page
    {
        // Instancia del cliente SOAP para interactuar con el servicio de Cliente.
        private static ServiceReference_Cliente.ClienteSoapClient cliente = new ServiceReference_Cliente.ClienteSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar el GridView con los datos de los clientes solo si no es un postback.
                CargarGrid();
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

        protected void GridView_Clientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // Salir del modo de edición y recargar el GridView.
            GridView_Clientes.EditIndex = -1;
            CargarGrid();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void GridView_Clientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Cambiar a modo de edición y recargar el GridView.
            GridView_Clientes.EditIndex = e.NewEditIndex;
            CargarGrid();
        }

        protected void GridView_Clientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowId = Convert.ToInt32(GridView_Clientes.DataKeys[e.RowIndex]["id"]);
            GridViewRow row = GridView_Clientes.Rows[e.RowIndex];
            // Obtener los valores editados en los TextBox de la fila.
            String nombre = (row.FindControl("TextBoxNombre") as TextBox).Text;
            String apellido = (row.FindControl("TextBoxApellido") as TextBox).Text;
            String email = (row.FindControl("TextBoxEmail") as TextBox).Text;
            String password = (row.FindControl("TextBoxPassword") as TextBox).Text;
            // Llamar al servicio para modificar el cliente y recargar el GridView.
            String mensaje = cliente.modificarCliente(rowId, nombre, apellido, email, password);
            CargarGrid();
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        private void CargarGrid()
        {
            // Obtener la información de los clientes desde el servicio y cargarla en el GridView.
            String jsonResult = cliente.mostrarCliente("");
            List<ClienteDB.Cliente> clientes = JsonConvert.DeserializeObject<List<ClienteDB.Cliente>>(jsonResult);
            GridView_Clientes.DataSource = clientes;
            GridView_Clientes.DataBind();
        }

        [WebMethod]
        public static string EliminarFila(int id)
        {
            int rowId = id;
            // Llamar al servicio para eliminar el cliente y retornar el resultado.
            String mensaje = cliente.eliminarCliente(rowId);
            return mensaje; // O "error" en caso de fallo
        }
    }
}
