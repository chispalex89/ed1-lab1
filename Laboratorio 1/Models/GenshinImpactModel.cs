using Laboratorio_1.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class GenshinImpactModel
    {
        

        [Required]
        [Range(1, 20)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CharacterName { get; set; }

        [Required]
        [Range(4,5)]
        public int Rarity { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string Element { get; set; }

        [Required]
        [MaxLength(10)]
        public string Weapon { get; set; }

        [Required]
        [MaxLength(10)]
        public string Nation { get; set; }

        [Required]
        [Range(300,500)]
        public int BaseAttack { get; set; }

        [Required]
        [Range(300, 500)]
        public int BaseDefense { get; set; }

        [Required]
        [Range(1000, 3000)]
        public int BaseHP { get; set; }



        public static bool Save(GenshinImpactModel model)
        {
            GenshinImpactData.Instance.genshinList.Add(model);
            return true;
        }

        public static void Edit(GenshinImpactModel model, int id)
        {
            GenshinImpactData.Instance.genshinList[id-1].CharacterName = model.CharacterName;
            GenshinImpactData.Instance.genshinList[id-1].Rarity = model.Rarity;
            GenshinImpactData.Instance.genshinList[id-1].Element = model.Element;
            GenshinImpactData.Instance.genshinList[id-1].Weapon = model.Weapon;
            GenshinImpactData.Instance.genshinList[id-1].Nation = model.Nation;
            GenshinImpactData.Instance.genshinList[id-1].BaseAttack = model.BaseAttack;
            GenshinImpactData.Instance.genshinList[id-1].BaseDefense = model.BaseDefense;
            GenshinImpactData.Instance.genshinList[id-1].BaseHP = model.BaseHP;
            
        }

        public static void Delete(GenshinImpactModel model)
        {
            GenshinImpactData.Instance.genshinList.Remove(model);
        }
      

    }
}
