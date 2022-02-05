using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio_1.Helpers;

namespace Laboratorio_1.Models
{
    public class AnimalCrossingModel
    {
        [Range(1, 10000)]
        public int Id { get; set; }
        [MaxLength(20)]
        [MinLength(1)]
        public string Name { get; set; }
        [MaxLength(15)]
        [MinLength(1)]
        public string Fruit { get; set; }
        [Range(1, 100)]
        public int Insects { get; set; }
        [Range(1, 200)]
        public int Animals { get; set; }
        [Range(1, 80)]
        public int Tricks { get; set; }
        [Range(1, 80)]
        public int Emotions { get; set; }

        public static bool Save(AnimalCrossingModel model)
        {
            Data.Instance.animalcrossingList.Add(model);
            return false;
        }

        public static bool Edit(AnimalCrossingModel model)
        {
            throw new NotImplementedException();
        }

        
    }
}
