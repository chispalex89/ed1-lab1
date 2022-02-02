using Laboratorio_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class Persona5Model
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Strenght { get; set; }

        public int Magic { get; set; }

        public int EnduranceOrVitality { get; set; }

        public int Agility { get; set; }

        public int Luck { get; set; }

        public static void Save(Persona5Model model)
        {
            DataPersona5.Instance.Persona5List.Add(model);
        }

        public static void Edit(Persona5Model model)
        {
            throw new NotImplementedException();
        }
    }
}
