using Laboratorio_1.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio_1.Models
{
    public class PokemonModel
    {
        [Range(1, 900)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(1, 255)]
        public int HP { get; set; }

        [Range(1, 255)] 
        public int Attack { get; set; }
        [Range(1, 255)] 
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }

        public static bool Save(PokemonModel model)
        {
            Data.Instance.pokemonList.Add(model);
            return false;
        }

        public static bool Edit(PokemonModel model)
        {
            throw new NotImplementedException();
        }
    }
}
