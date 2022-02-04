using Laboratorio_1.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class PeliculaModel
    {
        [Range(1, 1000)]
        public int ID { get; set; }
        [MaxLength(50)]
        [MinLength(1)]
        public string Nombre { get; set; }
        [Range(1,2022)]
        public int AñoPublicacion { get; set; }
        [Range(1,300)]
        public int Duracion { get; set; }
        [MaxLength(50)]
        [MinLength(1)]
        public string Genero { get; set; }
        [MaxLength(50)]
        [MinLength(1)]
        public string Director { get; set; }
        public bool Disponibilidad { get; set; }

        public static void Guardar(PeliculaModel Pelicula)
        {
            DataPelicula.Instancia.lPeliculas.Add(Pelicula);
        }

        public static bool Editar(int id, PeliculaModel Pelicula)
        {
            var lugar = DataPelicula.Instancia.lPeliculas.FindIndex(pelicula => pelicula.ID == id);
            DataPelicula.Instancia.lPeliculas[lugar] = new PeliculaModel
            {
                ID = id,
                Nombre = Pelicula.Nombre,
                AñoPublicacion = Pelicula.AñoPublicacion,
                Duracion = Pelicula.Duracion,
                Genero = Pelicula.Genero,
                Director = Pelicula.Director,
                Disponibilidad = Pelicula.Disponibilidad
            };
            return true;
        }

        public static void Borrar(PeliculaModel pelicula)
        {
            DataPelicula.Instancia.lPeliculas.Remove(pelicula);
        }
    }
}
