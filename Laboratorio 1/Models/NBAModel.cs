using Laboratorio_1.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class NBAModel
    {
        [Range(1, 30)]
        public int Equipo { get; set; }
        public string Base { get; set; }
        public string Escolta { get; set; }
        public string Alero { get; set; }
        public string AlaPivot { get; set; }
        public string Pivot { get; set; }
        public static bool Save(NBAModel model)
        {
            Data.Instance.nbaList.Add(model);
            return true;
        }
        public static bool Edit(NBAModel model)
        {
            throw new NotImplementedException();
        }
    }
}
