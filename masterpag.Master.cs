using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Poke_Web
{
    public partial class masterpag : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(Page is Registrarse || Page is Registro || Page is Tarjetas))
            {
                if (!Seguridad.SesionActiva(Session["usuario"]))
                {
                    Response.Redirect("Loguearse.aspx", false);
                }
            }
           
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Loguearse.aspx", false);
        }
    }
}