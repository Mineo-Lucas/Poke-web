using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Poke_Web
{
    public partial class EnviarEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            EmailService Mail = new EmailService();
            Mail.ArmarCorreo(TxtEmail.Text, TxtAsunto.Text, TxtMensaje.Text);
            try
            {
                Mail.EnviarEmail();
            }catch (Exception ex)
            {
                Session.Add("error", ex);
            }
        }
    }
}