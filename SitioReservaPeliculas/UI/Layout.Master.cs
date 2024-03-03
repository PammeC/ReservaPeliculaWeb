using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioReservaPeliculas.UI
{
    public partial class Layou : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    // Verificar si ya hay una sesión iniciada
            //    if (Session["UsuarioLogeado"] != null || Session["ClienteLogeado"] != null)
            //    {
            //        // Si hay una sesión iniciada, redirige al usuario a la página correspondiente
            //        if (Session["UsuarioLogeado"] != null)
            //        {
            //            Response.Redirect("PrincipalAdmin.aspx");
            //        }
            //        else if (Session["ClienteLogeado"] != null)
            //        {
            //            Response.Redirect("PrincipalUsuario.aspx");
            //        }
            //    }
            //}
        }


    }
}