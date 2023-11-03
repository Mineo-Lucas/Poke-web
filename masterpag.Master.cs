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
            if (!(Page is Registrarse || Page is Registro || Page is Tarjetas))
            {
                if (!Seguridad.SesionActiva(Session["usuario"]))
                {
                    Response.Redirect("Loguearse.aspx", false);
                }
            }
            
            
            if (Seguridad.SesionActiva(Session["usuario"])){
                if(((Usuario)Session["usuario"]).UrlImagen!= null)
                {
                    ImgPerfil.ImageUrl = "~/imagenes/" + ((Usuario)Session["usuario"]).UrlImagen;
                }
                else
                {
                    ImgPerfil.ImageUrl = "https://i.pinimg.com/280x280_RS/42/03/a5/4203a57a78f6f1b1cc8ce5750f614656.jpg";
                }     
            }
            else
            {
                ImgPerfil.ImageUrl = "https://i.pinimg.com/280x280_RS/42/03/a5/4203a57a78f6f1b1cc8ce5750f614656.jpg";
            }
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Loguearse.aspx", false);
        }
    }
}