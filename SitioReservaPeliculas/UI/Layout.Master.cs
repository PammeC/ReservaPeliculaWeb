using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static SitioReservaPeliculas.UI.PrincipalUsuario;

namespace SitioReservaPeliculas.UI
{
    public partial class Layout : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UsuarioLogeado"] != null)
                {
                    // El usuario es un administrador
                    RegresarLink.NavigateUrl = "PrincipalAdmin.aspx";
                }
                else if (Session["ClienteLogeado"] != null)
                {
                    // El usuario es un cliente
                    RegresarLink.NavigateUrl = "PrincipalUsuario.aspx";
                }
            }
        }






    }
}