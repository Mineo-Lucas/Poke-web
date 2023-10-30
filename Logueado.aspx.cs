using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poke_Web
{
    public partial class Logueado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"]==null)
            {
                Session.Add("error", "debes loguearte para ingresar");
                Response.Redirect("NoLogueado.aspx",false);
            }
        }
    }
}