using Laboratorio_1.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio_1.Models
{
    public class PokemonModel
    {
        [Range(1, 900)]
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(1)]
        public string Name { get; set; }
        [Range(1, 255)]
        public int HP { get; set; }
        [Range(1, 255)] 
        public int Attack { get; set; }
        [Range(1, 255)] 
        public int Defense { get; set; }
        [Range(1, 255)] 
        public int SpecialAttack { get; set; }
        [Range(1, 255)] 
        public int SpecialDefense { get; set; }
        [Range(1, 255)] 
        public int Speed { get; set; }

        public static bool Save(PokemonModel model)
        {
            Data.Instance.pokemonList.Add(model);
            return true;
        }

        public static bool Edit(int id, PokemonModel model)
        {
            var position = Data.Instance.pokemonList.FindIndex(pokemon => pokemon.Id == id);
            Data.Instance.pokemonList[position] = new PokemonModel
            {
                Id = id,
                HP = model.HP,
                Name = model.Name,
                Attack = model.Attack,
                Defense = model.Defense,
                SpecialAttack = model.SpecialAttack,
                SpecialDefense = model.SpecialDefense,
                Speed = model.Speed
            };

            return true;
        }
    }
}
