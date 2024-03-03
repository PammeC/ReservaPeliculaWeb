using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using static SitioReservaPeliculas.Modelos.PeliculaDB;

namespace SitioReservaPeliculas.UI
{
    public partial class ListadoPeliculas : System.Web.UI.Page
    {
        private static ServiceReference_Pelicula.PeliculaSoapClient pelicula = new ServiceReference_Pelicula.PeliculaSoapClient();
        // Creación de un cliente para el servicio web de peliculas.

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

        protected void GridView_Peliculas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowId = Convert.ToInt32(GridView_Peliculas.DataKeys[e.RowIndex]["id"]);
            GridViewRow row = GridView_Peliculas.Rows[e.RowIndex];
            String nombre = (row.FindControl("TextBoxNombre") as TextBox).Text;
            String descripcion = (row.FindControl("TextBoxDescripcion") as TextBox).Text;
            String categoria = (row.FindControl("TextBoxCategoria") as TextBox).Text;
            String mensaje = pelicula.modificarPelicula(rowId, nombre, descripcion, int.Parse(categoria));
            CargarGrid(); // Recarga los datos en el GridView.
            Response.Redirect(Request.Url.AbsoluteUri); // Redirige a la misma página.
        }

        protected void GridView_Peliculas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView_Peliculas.EditIndex = e.NewEditIndex; // Cambiar a modo de edición.
            CargarGrid(); // Recarga los datos en el GridView.
        }

        protected void GridView_Peliculas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView_Peliculas.EditIndex = -1; // Salir del modo de edición.
            CargarGrid(); // Recarga los datos en el GridView.
            Response.Redirect(Request.Url.AbsoluteUri); // Redirige a la misma página.
        }

        private void CargarGrid()
        {
            String jsonResult = pelicula.mostrarPelicula(""); // Obtiene datos de peliculas en formato JSON.
            List<Pelicula> peliculas = JsonConvert.DeserializeObject<List<Pelicula>>(jsonResult); // Deserializa los datos JSON.
            GridView_Peliculas.DataSource = peliculas; // Asigna los datos al GridView.
            GridView_Peliculas.DataBind(); // Enlaza y muestra los datos en el GridView.
        }

        [WebMethod]
        public static string EliminarFila(int id)
        {
            int rowId = id;
            String mensaje = pelicula.eliminarPelicula(rowId); // Llama al método del servicio web para eliminar un pelicula.
            return mensaje; // Retorna "success" o "error" en caso de fallo.
        }
    }
}
