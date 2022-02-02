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
    }
}
