using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioReservaPeliculas.UI
{
    public partial class RegistroPeliculas : System.Web.UI.Page
    {
        private static ServiceReference_Pelicula.PeliculaSoapClient pelicula = new ServiceReference_Pelicula.PeliculaSoapClient();

        // Propiedades para controlar la visibilidad de las alertas en la página
        public bool Alerta { get; set; } = false;
        public bool Info { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Llamar al método para listar las categorias
                ListarCategoria();
                DataBind();
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

        // Método para listar las categorias en el DropDownList
        private void ListarCategoria()
        {
            String jsonResult = pelicula.listarCategoria();
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);

            // Crear una fila por defecto para el DropDownList
            DataRow defaultRow = dt.NewRow();
            defaultRow["id"] = 0; // Valor en blanco o null para el valor por defecto
            defaultRow["nombre"] = "Selecciona una categoria"; // Texto del valor por defecto
            dt.Rows.InsertAt(defaultRow, 0);

            DropDownList_Categoria.DataSource = dt;
            DropDownList_Categoria.DataTextField = "nombre";
            DropDownList_Categoria.DataValueField = "id";
            DropDownList_Categoria.DataBind();
        }

        protected void Button_Registrar_Click(object sender, EventArgs e)
        {
            String mensajeR = "";

            // Verificar que se hayan completado los campos necesarios
            if (TextBox_Nombre.Text != "" && TextBox_Descripcion.Text != "" && Convert.ToInt32(DropDownList_Categoria.SelectedValue) != 0)
            {
                // Llamar al método para registrar al pelicula
                mensajeR = pelicula.registrarPelicula(TextBox_Nombre.Text, TextBox_Descripcion.Text, Convert.ToInt32(DropDownList_Categoria.SelectedValue));

                // Mostrar mensaje de éxito y limpiar los campos
                Label_Info.Text = mensajeR;
                TextBox_Nombre.Text = "";
                TextBox_Descripcion.Text = "";
                DropDownList_Categoria.SelectedIndex = 0;
                Alerta = false;
                Info = true;
                DataBind();
            }
            else
            {
                // Mostrar alerta si no se han completado todos los campos
                mensajeR = "Es necesario que llene todos los campos";
                Label_Alerta.Text = mensajeR;
                Alerta = true;
                DataBind();
            }
        }
    }
}
