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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevo = new Usuario(TxtEmail.Text, TxtPass.Text, false) ; 
                UserNegocio conec= new UserNegocio();
                EmailService enviarEmail = new EmailService() ;
                //nuevo.Email = TxtEmail.Text;
                //nuevo.Pass = TxtPass.Text;
                nuevo.Id= conec.Registrarse(nuevo);
                Session.Add("usuario", nuevo);
                //enviarEmail.ArmarCorreo(nuevo.Email, "Bienvenidooo", "holaaa nuevo integrante");
                //enviarEmail.EnviarEmail();
                Response.Redirect("Tarjetas.aspx", false);
            }
            catch (Exception ex)
            {

                Session.Add("Error", ex);
            }

        }
    }
}