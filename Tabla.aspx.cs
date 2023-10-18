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
    public partial class Tabla : System.Web.UI.Page
    {
        public bool FiltroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            FiltroAvanzado = CbxFiltroAvanzado.Checked;
            if (!IsPostBack)
            {
                POKEMONSNEGOCIO negocio = new POKEMONSNEGOCIO();
                Session.Add("listapokemons", negocio.ListarSP());
                DgvPokedex.DataSource = Session["listapokemons"];
                DgvPokedex.DataBind();
            }
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

        protected void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<POKEMONS> lista = (List<POKEMONS>)Session["listapokemons"];
            List<POKEMONS> listafiltrada = lista.FindAll(x => x.nombre.ToUpper().Contains(TxtFiltro.Text.ToUpper()));
            DgvPokedex.DataSource= listafiltrada;
            DgvPokedex.DataBind();
        }

        protected void CbxFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            FiltroAvanzado= CbxFiltroAvanzado.Checked;
            TxtFiltro.Enabled = !FiltroAvanzado;
        }

        protected void DdlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DdlCriterio.Items.Clear();
            if(DdlCampo.SelectedItem.ToString() == "Numero")
            {
                DdlCriterio.Items.Add("Mayor a");
                DdlCriterio.Items.Add("Menor a");
                DdlCriterio.Items.Add("Igual a");
            }
            else
            {
                DdlCriterio.Items.Add("Empieza con");
                DdlCriterio.Items.Add("Termina con");
                DdlCriterio.Items.Add("Contiene");
            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
             POKEMONSNEGOCIO pokenego = new POKEMONSNEGOCIO();
             DgvPokedex.DataSource=pokenego.filtrar(DdlCampo.SelectedItem.ToString(),DdlCriterio.SelectedItem.ToString(),TxtFiltroAvanzado.Text);
             DgvPokedex.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}