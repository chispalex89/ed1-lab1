using Laboratorio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Helpers
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

        public List<PokemonModel> pokemonList = new List<PokemonModel>
        {
            new PokemonModel
            {
                Id = 7,
                Name = "Squirtle",
                HP = 44,
                Attack = 48,
                Defense = 65,
                SpecialAttack = 50,
                SpecialDefense = 64,
                Speed = 43
            }
        };

        public List<NBAModel> nbaList = new List<NBAModel>
        {
            new NBAModel
            {
                Equipo = 1,
                Base = "James Harden",
                Escolta = "Blake Griffin",
                Alero = "Kyrie Irving",
                AlaPivot = "Kevin Durant",
                Pivot = "Nicolas Claxton"
            }
        };

        public List<Dogmodel> DogList = new List<Dogmodel>
        {
            new Dogmodel
            {
                Id = 1,
                Name = "Lalo",
                Race = "Golden",
                Weight = 30,
                Height = 20
            }
        };
    }
}
