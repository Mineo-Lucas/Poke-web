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
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            UserNegocio nego = new UserNegocio();
            Usuario usuario;
            try
            {
                usuario = new Usuario(TxtEmail.Text, TxtPass.Text, false);
                if (nego.Loguear(usuario))
                {
                    Session.Add("usuario", usuario);
                    Response.Redirect("Logueado.aspx", false);
                }
                else
                {
                    Response.Redirect("NoLogueado.aspx", false);
                }

            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }


    }
}