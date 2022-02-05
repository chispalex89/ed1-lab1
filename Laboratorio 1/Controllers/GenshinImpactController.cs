using Laboratorio_1.Helpers;
using Laboratorio_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Controllers
{
    public class GenshinImpactController : Controller
    {
        // GET: GenshinImpactController1
        public ActionResult Index()
        {
            return View(GenshinImpactData.Instance.genshinList);
        }

        // GET: GenshinImpactController1/Details/5
        public ActionResult Details(int id)
        {
            var model = GenshinImpactData.Instance.genshinList.Find(character => character.Id == id);
            return View(model);
        }

        // GET: GenshinImpactController1/Create
        public ActionResult Create()
        {
            return View(new GenshinImpactModel());
        }

        // POST: GenshinImpactController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
           
            try
            {
                
                var response = GenshinImpactModel.Save(new GenshinImpactModel
                {                  
                    Id = int.Parse(collection["Id"]),                 
                    CharacterName = collection["CharacterName"],
                    Rarity = int.Parse(collection["Rarity"]),
                    Element = collection["Element"],
                    Weapon = collection["Weapon"],
                    Nation = collection["Nation"],
                    BaseAttack = int.Parse(collection["BaseAttack"]),
                    BaseDefense = int.Parse(collection["BaseDefense"]),
                    BaseHP = int.Parse(collection["BaseHP"])
                    
                });

                if (response)
                {
                    return RedirectToAction(nameof(Index));
                }
                ViewBag["Error"] = "Error while creating new element";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenshinImpactController1/Edit/5
        public ActionResult Edit(int id)
        {
            var model = GenshinImpactData.Instance.genshinList.Find(character => character.Id == id);
            return View(model);
        }

        // POST: GenshinImpactController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var model = GenshinImpactData.Instance.genshinList.Find(Character => Character.Id == id);
                model.CharacterName = collection["CharacterName"];
                model.Rarity = int.Parse(collection["Rarity"]);
                model.Element = collection["Element"];
                model.Weapon = collection["Weapon"];
                model.Nation = collection["Nation"];
                model.BaseAttack = int.Parse(collection["BaseAttack"]);
                model.BaseDefense = int.Parse(collection["BaseDefense"]);
                model.BaseHP = int.Parse(collection["BaseHP"]);
                GenshinImpactModel.Edit(model, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GenshinImpactController1/Delete/5
        public ActionResult Delete(int id)
        {
            var model = GenshinImpactData.Instance.genshinList.Find(character => character.Id == id);
            return View(model);
        }

        // POST: GenshinImpactController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var model = GenshinImpactData.Instance.genshinList.Find(character => character.Id == id);
                GenshinImpactModel.Delete(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
