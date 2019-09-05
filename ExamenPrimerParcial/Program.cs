using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();
            Playlist playlist1 = new Playlist("Chill", "Relajate en tu día de descanso");
            Playlist playlist2 = new Playlist("Niños", "Crea recuerdos en tus niños");

            playlists.Add(playlist1);
            playlists.Add(playlist2);

            Película toyStory = new Película("Toy Story", 1995 , "Yo" ,"aventura" , "EU" , 10 , 8.2 , "alguna");
            Película laBellayLaBestia = new Película("La Bella y la Bestia", 1992 , "xd", "algo", "Mex", 10, 8.2, "alguna");
            Película enredados = new Película("Enredados", 2010 , "xd", "algo", "Mex", 10, 9.5, "alguna");
            Película reyLeón = new Película("El Rey León", 1995 , "xd", "algo", "Mex", 10, 4.2, "alguna");
            Película zootopia = new Película("Zootopia", 2015 , "xd", "algo", "Mex", 10, 9.3, "alguna");
            Película bigHero = new Película("Big Hero 6", 2016 , "xd", "algo", "Mex", 10, 8.9, "alguna");
            Película nemo = new Película("Buscando a Nemo", 2005 , "xd", "algo", "Mex", 10, 9.1, "alguna");

            Película django = new Película("Django sin cadenas", 2012 , "xd", "algo", "Mex", 10, 8.2, "alguna");
            Película muerteAnunciada = new Película("Muerte Anunciada", 2006 , "xd", "algo", "Mex", 10, 8.2, "alguna");
            Película johnWick1 = new Película("John Wick: Otro día para matar", 2014 , "xd", "algo", "Mex", 10, 8.2, "alguna");
            Película johnWick2 = new Película("John Wick: Un nuevo día para matar", 2017 , "xd", "algo", "Mex", 10, 8.2, "alguna");
            Película johnWick3 = new Película("John Wick: Parabellum", 2019 , "xd", "algo", "Mex", 10, 8.2, "alguna");
            Película loboWall = new Película("El Lobo de Wall Street", 2013 , "xd", "algo", "Mex", 10, 8.2, "alguna");
            Película bastardos = new Película("Bastardos sin gloria", 2009 , "xd", "algo", "Mex", 10, 8.2, "alguna");

            playlist1.Películas.Add(django);
            playlist1.Películas.Add(muerteAnunciada);
            playlist1.Películas.Add(johnWick1);
            playlist1.Películas.Add(johnWick2);
            playlist1.Películas.Add(johnWick3);
            playlist1.Películas.Add(loboWall);
            playlist1.Películas.Add(bastardos);

            playlist2.Películas.Add(laBellayLaBestia);
            playlist2.Películas.Add(enredados);
            playlist2.Películas.Add(reyLeón);
            playlist2.Películas.Add(zootopia);
            playlist2.Películas.Add(bigHero);
            playlist2.Películas.Add(nemo);
            playlist2.Películas.Add(toyStory);

            foreach(Playlist playlist in playlists)
            {
                Console.WriteLine("Playlist:    " + playlist.TituloP);
                Console.WriteLine("Descipción:    " + playlist.Descripcion);
                Console.WriteLine("\n");
                Console.WriteLine("Lista de películas:");
                

                foreach(Película película in playlist.Películas)
                {
                    Console.WriteLine("  - " + película.Titulo);
                    
                }
                
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
