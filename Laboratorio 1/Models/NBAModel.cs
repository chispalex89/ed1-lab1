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
        [MaxLength(50)]
        public string Team { get; set; }
        [MaxLength(50)]
        public string Center { get; set; }
        [MaxLength(50)]
        public string PowerForward { get; set; }
        [MaxLength(50)]
        public string SmallForward { get; set; }
        [MaxLength(50)]
        public string PointGuard { get; set; }
        [MaxLength(50)]
        public string ShootingGuard { get; set; }
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
