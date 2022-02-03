using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio_1.Helpers;

namespace Laboratorio_1.Models
{
    public class AnimalCrossingModel
    {
        public string Name { get; set; }
        public string Fruit { get; set; }
        public int Insects { get; set; }
        public int Animals { get; set; }
        public int Tricks { get; set; }
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
