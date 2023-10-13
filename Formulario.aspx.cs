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
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ElementosNegocio nego= new ElementosNegocio();
            List<Elementos> lista= nego.Listar();
            DdlTipo.DataSource = lista;
            DdlTipo.DataValueField = "Id";
            DdlTipo.DataTextField = "Descripcion";
            DdlTipo.DataBind();

            DdlDebilidad.DataSource = lista;
            DdlDebilidad.DataValueField = "Id";
            DdlDebilidad.DataTextField = "Descripcion";
            DdlDebilidad.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}