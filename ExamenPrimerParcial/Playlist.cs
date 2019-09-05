using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlist
    {
        public string TituloP { get; set; }
        public string Descripcion { get; set; }
        public List<Película> Películas { get; set; }

        public Playlist()
        {
            TituloP = "Sin Asignar";
            Descripcion = "Sin Asignar";
            Películas = new List<Película>();
        }

        public Playlist(string tituloP , string descripcion)
        {
            TituloP = tituloP;
            Descripcion = descripcion;
            Películas = new List<Película>();
        }
    }
}
