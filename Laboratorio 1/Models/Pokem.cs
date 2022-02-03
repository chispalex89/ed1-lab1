using Lab_1.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Models
{
    public class Pokem
    {
        public int Gene { get; set; }

        public string Name { get; set; }

        
        public string Type { get; set; }

        public string Gender { get; set; }

        public static bool Save(Pokem model)
        {
            Data.Instance.pokemonlist.Add(model);
            return true;
        }
    }
}
