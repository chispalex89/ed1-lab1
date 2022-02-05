using Laboratorio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Helpers
{
    public class DataPelicula
    {
        private static DataPelicula _instancia = null;

        public static DataPelicula Instancia
        {
            get {
                if (_instancia == null)
                {
                    _instancia = new DataPelicula();
                }
                return _instancia;
            }
        }

        public List<PeliculaModel> lPeliculas = new List<PeliculaModel>
            {
                new PeliculaModel
                {
                    ID = 1,
                    Nombre = "1917",
                    AñoPublicacion = 2019,
                    Duracion = 119,
                    Genero = "Suspenso",
                    Director = "Sam Mendez",
                    Disponibilidad = true
                },
                new PeliculaModel
                {
                    ID = 2,
                    Nombre = "Truman Show: historia de una vida",
                    AñoPublicacion = 1998,
                    Duracion = 103,
                    Genero = "Comedia Dramática",
                    Director = "Peter Weir",
                    Disponibilidad = false
                }

        };
    }
}
