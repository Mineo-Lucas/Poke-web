﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poke_Web
{
    public partial class Tabla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            POKEMONSNEGOCIO negocio= new POKEMONSNEGOCIO();
            DgvPokedex.DataSource = negocio.ListarSP();
            DgvPokedex.DataBind();
        }

        protected void DgvPokedex_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id=DgvPokedex.SelectedDataKey.Value.ToString();
            Response.Redirect("Formulario.aspx?Id="+ id);
        }

        protected void DgvPokedex_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DgvPokedex.PageIndex = e.NewPageIndex;
            DgvPokedex.DataBind();
        }
    }
}