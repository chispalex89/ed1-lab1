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

        public List<AnimalCrossingModel> animalcrossingList = new List<AnimalCrossingModel>
        {
            new AnimalCrossingModel
            {
                Id= 1,
                Name = "Kelly",
                Fruit = "Peach",
                Insects = 48,
                Animals = 20,
                Tricks = 12,
                Emotions = 2
            }
        };
    }
}
