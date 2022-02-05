using Laboratorio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Helpers
{
    public class DataPersona5
    {
        private static DataPersona5 _instance = null;

        public static  DataPersona5 Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new DataPersona5();
                }
                return _instance;
            }
        }

        public List<Persona5Model> Persona5List= new List<Persona5Model> 
         {
                new Persona5Model
                {
                Id = "Fool",
                Name = "Arsène",
                Strenght = 24,
                Magic = 24,
                EnduranceOrVitality = 24,
                Agility = 39,
                Luck = 10,
                }
            };
    }
}
