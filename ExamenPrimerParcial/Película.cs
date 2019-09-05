using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Película
    {
        public string Titulo { get; set; }
        private int _año;
        public int Año
        {
            get
            {
                return _año;
            }
            set
            {
                if(value < 1800 || value > 2019)
                {
                    throw new Exception("Debe ser entre 1800 y 2019");
                }
            }
        }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string PaisOrigen { get; set; }
        private int _duracion;
        public int Duracion
        {
            get
            {
                return _duracion;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Debe durar más de 0 minutos");
                }
            }
        }
        private double _ratingIMDB;
        public double RatingIMDB
        {
            get
            {
               return _ratingIMDB;
            }
            set
            {
                if(value < 0 || value > 10)
                {
                    throw new Exception("Debe estar en un rango de 0 a 10");
                }
            }
        }
        public string Sinopsis { get; set; }

        public Película()
        {
            Titulo = "Sin Asignar";
            Año = 0;
            Director = "Sin Asignar";
            Genero = "Sin Asignar";
            PaisOrigen = "Sin Asignar";
            Duracion = 0;
            RatingIMDB = 0;
            Sinopsis = "Sin Asignar";
        }

        public Película(string titulo , int año , string director , string genero , string paisOrigen , int duracion , double ratingIMDB , string sinopsis)
        {
            Titulo = titulo;
            Año = año;
            Director = director;
            Genero = genero;
            PaisOrigen = paisOrigen;
            Duracion = duracion;
            RatingIMDB = ratingIMDB;
            Sinopsis = sinopsis;
        }

    }
}
