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
    public partial class RegistroCategorias : System.Web.UI.Page
    {
        private static ServiceReference_Categoria.CategoriaSoapClient categoria = new ServiceReference_Categoria.CategoriaSoapClient();

        // Propiedad para mostrar alertas de error en la página
        public bool Alerta { get; set; } = false;

        // Propiedad para mostrar mensajes informativos en la página
        public bool Info { get; set; } = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si la página se está cargando por primera vez (no es un postback)
            if (!IsPostBack)
            {
                // Asociar los valores a las propiedades de la página para mostrar las alertas y mensajes informativos
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

        protected void Button_Registrar_Click(object sender, EventArgs e)
        {
            String mensajeR = "";

            // Verificar si se ha ingresado un nombre de especialidad válido
            if (TextBox_Nombre.Text != "")
            {
                // Llamar al método del servicio web para registrar una nueva especialidad
                mensajeR = categoria.registrarCategoria(TextBox_Nombre.Text);

                // Mostrar el mensaje de éxito en la etiqueta correspondiente
                Label_Info.Text = mensajeR;

                // Limpiar el campo de ingreso de nombre de especialidad
                TextBox_Nombre.Text = "";

                // Asociar los valores a las propiedades para mostrar los mensajes en la página
                Alerta = false;
                Info = true;
                DataBind();
            }
            else
            {
                // Mostrar un mensaje de alerta si no se ingresó un nombre de especialidad
                mensajeR = "Es necesario que llene todos los campos";

                // Mostrar el mensaje de alerta en la etiqueta correspondiente
                Label_Alerta.Text = mensajeR;

                // Asociar los valores a las propiedades para mostrar los mensajes en la página
                Alerta = true;
                DataBind();
            }
        }
    }
}