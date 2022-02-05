using Laboratorio_1.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Laboratorio_1.Models
{
    public class Persona5Model
    {
        [MaxLength(30)]
        [MinLength(1)]
        public string Id { get; set; }

        [MaxLength(30)]
        [MinLength(1)]
        public string Name { get; set; }

        [Range(1, 900)]
        public int Strenght { get; set; }

        [Range(1, 900)]
        public int Magic { get; set; }

        [Range(1, 900)]
        public int EnduranceOrVitality { get; set; }

        [Range(1, 900)]
        public int Agility { get; set; }

        [Range(1, 900)]
        public int Luck { get; set; }

        public static void Save(Persona5Model model)
        {
            DataPersona5.Instance.Persona5List.Add(model);
        }

        public static void Edit(string id, Persona5Model persona5)
        {
            var lugar = DataPersona5.Instance.Persona5List.FindIndex(persona5 => persona5.Id == id);
            DataPersona5.Instance.Persona5List[lugar] = new Persona5Model
            {
                Id = id,
                Name = persona5.Name,
                Strenght = persona5.Strenght,
                Magic = persona5.Magic,
                EnduranceOrVitality = persona5.EnduranceOrVitality,
                Agility = persona5.Agility,
                Luck = persona5.Luck
            };
        }
    }
}
