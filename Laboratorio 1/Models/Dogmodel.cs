using Laboratorio_1.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class Dogmodel
    {
        [Range(1, 900)]
        public int Id { get; set; }
        [MaxLength(100)]
        [MinLength(1)]
        public string Name { get; set; }
        [MaxLength(100)]
        [MinLength(1)]
        public string Race { get; set; }
        [Range(1, 100)]
        public int Weight { get; set; }
        [Range(1, 100)]
        public int Height { get; set; }

        public static bool Save(Dogmodel model)
        {
            Data.Instance.DogList.Add(model);
            return true;
        }

        public static bool Edit(int id, Dogmodel model)
        {
            var position = Data.Instance.DogList.FindIndex(dog => dog.Id == id);
            Data.Instance.DogList[position] = new Dogmodel
            {
                Id = id,
                Name = model.Name,
                Race = model.Race,
                Weight = model.Weight,
                Height = model.Height
            };
            return true;
        }

        public static bool Delete(int id)
        {
            var position = Data.Instance.DogList.FindIndex(dog => dog.Id == id);
            Data.Instance.DogList.RemoveAt(position);
            return true;
        }
    }
}
