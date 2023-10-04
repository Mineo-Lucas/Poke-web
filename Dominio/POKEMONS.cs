using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class POKEMONS
    {
         
        public string nombre { get; set; }
        public string descripcion { get; set;}
        public int numero { get; set; }
       
        public string urlimagen { get; set; }

        public Elementos Tipo { get; set; }
        public Elementos debilidad { get; set; }

        public int Id { get; set; }
    }
}
