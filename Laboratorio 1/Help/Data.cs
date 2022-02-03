using Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_1.Help
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public List<Pokem> pokemonlist = new List<Pokem>
        {
            new Pokem
            {
                Gene = 1,
                Name = "Bulbasaur",
                Gender = "Male",
                Type = "Grass - Poison"
            }
        };

    }
}
