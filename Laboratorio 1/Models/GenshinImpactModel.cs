using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class GenshinImpactModel
    {
        public string CharacterName { get; set; }

        public int Rarity { get; set; }

        public string Element { get; set; }

        public string Weapon { get; set; }

        public string Nation { get; set; }

        public int BaseAttack { get; set; }

        public int BaseDefense { get; set; }

        public int BaseHP { get; set; }
    }
}
