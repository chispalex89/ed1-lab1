using Lab_1.Help;
using Lab_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokem = Lab_1.Help.Pokem;

namespace Lab_1.Controllers
{
    public class PokeController : Controller
    {
        // GET: PokeController
        public ActionResult Index()
        {
         
            return View(Data.Instance.pokemonlist);
        }

        // GET: PokeController/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.pokemonlist.Find(poke => poke.Id == id);
            return View(model);
        }

        // GET: PokeController/Create
        public ActionResult Create()
        {
            return View(new Pokem());
        }

        // POST: PokeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = (Pokem.Save(new Pokem
                {
                    Name = collection["Name"],
                    Gene = int.Parse(collection["Gene"]),
                    Type = collection["Type"],
                    Gender = collection["Gender"],
                }));
                if ((bool)response)
                {
                    return RedirectToAction(nameof(Index));
                }
                ViewBag["Error"] = "Error al crear nuevo elemento";
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: PokeController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Data.Instance.pokemonlist.Find(poke => poke.Id == id);
            return View(model);
        }

        // POST: PokeController/Edit/5
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

        // GET: PokeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PokeController/Delete/5
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
