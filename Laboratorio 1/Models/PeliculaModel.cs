using Laboratorio_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class PeliculaModel
    {
        public string Nombre { get; set; }
        public int AñoPublicacion { get; set; }
        public double Duracion { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public bool Disponibilidad { get; set; }

        public static void Guardar(PeliculaModel Pelicula)
        {
            DataPelicula.Instancia.lPeliculas.Add(Pelicula);
        }

        public static bool Editar(PeliculaModel Pelicula)
        {
            throw new NotImplementedException();
        }
    }
}
