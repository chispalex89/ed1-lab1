using Laboratorio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Helpers
{
    public class GenshinImpactData
    {
        private static GenshinImpactData _instance = null;

        public static GenshinImpactData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GenshinImpactData();
                }
                return _instance;
            }
        }

        public List<GenshinImpactModel> genshinList = new List<GenshinImpactModel>
        {
            new GenshinImpactModel
            {
                Id = 1,
                CharacterName = "Arataki Itto",
                Rarity = 5,
                Element = "Geo",
                Weapon = "Claymore",
                Nation = "Inazuma",
                BaseAttack = 300,
                BaseDefense = 500,
                BaseHP = 1500
            }
        };
    }
}
