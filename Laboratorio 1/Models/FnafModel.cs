using System;
using Laboratorio_1.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class FnafModel
    {

        public string Game { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public int Frecuency { get; set; }

        public static bool Save(FnafModel model)
        {
            Data.Instance.fnafList.Add(model);
            return true;
        }

        public static bool Edit(FnafModel model)
        {
            throw new NotImplementedException();
        }

    }
}
