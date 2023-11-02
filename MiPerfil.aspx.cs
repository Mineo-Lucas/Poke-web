using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poke_Web
{
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Usuario"];
            UserNegocio nego = new UserNegocio();
            try
            {
                string ruta = Server.MapPath("./Imagenes/");
                TxtImagen.PostedFile.SaveAs(ruta+"perfil"+ user.Id+".jpg");

                user.UrlImagen ="perfil" + user.Id + ".jpg";
                nego.modificar(user);

                Image img = (Image)Master.FindControl("ImgPerfil");
                img.ImageUrl = "~/Imagenes/" + user.UrlImagen;
            }
            catch (Exception ex)
            {

                Session.Add("error.aspx",ex.ToString());
            }
        }
    }
}