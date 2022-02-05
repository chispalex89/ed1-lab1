using Laboratorio_1.Helpers;
using System.Collections.Generic;
using Laboratorio_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio_1.Controllers
{
    public class AnimalCrossingController : Controller //No se puede crear variables globlales en el controller
    {
        
        // GET: AnimalCrossingController
        public ActionResult Index()
        {
            return View(Data.Instance.animalcrossingList);
        }

        // GET: AnimalCrossingController/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.animalcrossingList.Find(player => player.Id == id);
            return View(model);
        }

        // GET: AnimalCrossingController/Create
        public ActionResult Create()
        {
            return View(new AnimalCrossingModel());
        }

        // POST: AnimalCrossingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = AnimalCrossingModel.Save(new AnimalCrossingModel
                {
                    Id= int.Parse(collection["Id"]),
                    Name = collection["Name"],
                    Fruit = collection["Fruit"],
                    Insects = int.Parse(collection["Insects"]),
                    Animals = int.Parse(collection["Animals"]),
                    Tricks = int.Parse(collection["Tricks"]),
                    Emotions = int.Parse(collection["Emotions"]),
                });

                if (response)
                {
                    return RedirectToAction(nameof(Index));
                }
                ViewBag["Error"] = "Error while creating new element";
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalCrossingController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Data.Instance.animalcrossingList.Find(player => player.Id == id);
            return View(model);
        }

        // POST: AnimalCrossingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalCrossingController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Data.Instance.animalcrossingList.Find(player => player.Id == id);
            return View();
        }

        // POST: AnimalCrossingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
