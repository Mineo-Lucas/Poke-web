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
    public partial class Tarjetas : System.Web.UI.Page
    {
        public List<POKEMONS> listapokemons { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            POKEMONSNEGOCIO negocio = new POKEMONSNEGOCIO();
            listapokemons = negocio.ListarSP();
        }
    }
}