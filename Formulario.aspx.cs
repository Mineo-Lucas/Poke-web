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
            if (!IsPostBack)
            {
                DdlTipo.DataSource = lista;
                DdlTipo.DataValueField = "Id";
                DdlTipo.DataTextField = "Descripcion";
                DdlTipo.DataBind();

                DdlDebilidad.DataSource = lista;
                DdlDebilidad.DataValueField = "Id";
                DdlDebilidad.DataTextField = "Descripcion";
                DdlDebilidad.DataBind();
            }

            string id= Request.QueryString["id"] != null ? Request.QueryString["id"].ToString():"";
            if (id != "" && !IsPostBack)
            {
                POKEMONSNEGOCIO negocio = new POKEMONSNEGOCIO();
                POKEMONS seleccionado = (negocio.Listar(id))[0];
                
                TxtId.Text= seleccionado.Id.ToString();
                TxtNombre.Text = seleccionado.nombre;
                TxtNumero.Text = seleccionado.numero.ToString();
                TxtDescripcion.Text = seleccionado.descripcion;
                TxtUrlImagen.Text = seleccionado.urlimagen;
                DdlDebilidad.SelectedValue = seleccionado.debilidad.id.ToString();
                DdlTipo.SelectedValue=seleccionado.Tipo.id.ToString();

            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            POKEMONS poke= new POKEMONS();
            POKEMONSNEGOCIO listanuevo = new POKEMONSNEGOCIO();
            try
            {
                poke.numero = int.Parse(TxtNumero.Text);
                poke.nombre = TxtNombre.Text;
                poke.urlimagen = TxtUrlImagen.Text;
                poke.descripcion = TxtDescripcion.Text;
                poke.Tipo = new Elementos();
                poke.Tipo.id = int.Parse(DdlTipo.SelectedValue);
                poke.debilidad = new Elementos();
                poke.debilidad.id = int.Parse(DdlDebilidad.SelectedValue);

                if (Request.QueryString["id"]!= null)
                {
                    poke.Id = int.Parse(TxtId.Text);
                    listanuevo.modificarconSP(poke);
                }
                else
                {
                     listanuevo.ingresar(poke);
                }
                
                Response.Redirect("Tabla.aspx");
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            POKEMONSNEGOCIO seleccionado = new POKEMONSNEGOCIO();
            int id= int.Parse(Request.QueryString["id"]);
            seleccionado.eliminar(id);
            Response.Redirect("Tabla.aspx");
        }
    }
}