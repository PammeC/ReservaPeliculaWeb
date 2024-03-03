using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using static SitioReservaPeliculas.Modelos.CategoriaDB;

namespace SitioReservaPeliculas.UI
{
    public partial class ListadoCategorias : System.Web.UI.Page
    {
        private static ServiceReference_Categoria.CategoriaSoapClient categoria = new ServiceReference_Categoria.CategoriaSoapClient();
        // Creación de un cliente para el servicio web de categorias.

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

        protected void GridView_Categorias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView_Categorias.EditIndex = -1; // Salir del modo de edición.
            CargarGrid(); // Recarga los datos en el GridView.
            Response.Redirect(Request.Url.AbsoluteUri); // Redirige a la misma página.
        }

        protected void GridView_Categorias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView_Categorias.EditIndex = e.NewEditIndex; // Cambiar a modo de edición.
            CargarGrid(); // Recarga los datos en el GridView.
        }

        protected void GridView_Categorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowId = Convert.ToInt32(GridView_Categorias.DataKeys[e.RowIndex]["id"]);
            GridViewRow row = GridView_Categorias.Rows[e.RowIndex];
            String nombre = (row.FindControl("TextBoxNombre") as TextBox).Text;
            String mensaje = categoria.modificarCategoria(rowId, nombre);
            // Llama al método del servicio web para modificar el nombre de una categoria.
            CargarGrid(); // Recarga los datos en el GridView.
            Response.Redirect(Request.Url.AbsoluteUri); // Redirige a la misma página.
        }

        private void CargarGrid()
        {
            String jsonResult = categoria.TraerCategoria(""); // Obtiene datos de categorias en formato JSON.
            List<Categoria> categoriaL = JsonConvert.DeserializeObject<List<Categoria>>(jsonResult); // Deserializa los datos JSON.
            GridView_Categorias.DataSource = categoriaL; // Asigna los datos al GridView.
            GridView_Categorias.DataBind(); // Enlaza y muestra los datos en el GridView.
        }

        [WebMethod]
        public static string EliminarFila(int id)
        {
            int rowId = id;
            String mensaje = categoria.eliminarCategoria(rowId); // Llama al método del servicio web para eliminar una categoria.
            return mensaje; // Retorna "success" o "error" en caso de fallo.
        }
    }
}
