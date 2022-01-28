using Laboratorio_1.Helpers;
using Laboratorio_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Laboratorio_1.Controllers
{
    public class PokemonController : Controller
    {
        // GET: PokemonController
        public ActionResult Index()
        {
            
            return View(Data.Instance.pokemonList);
        }

        // GET: PokemonController/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.pokemonList.Find(pokemon => pokemon.Id == id);
            return View(model);
        }

        // GET: PokemonController/Create
        public ActionResult Create()
        {
            return View(new PokemonModel());
        }

        // POST: PokemonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = PokemonModel.Save(new PokemonModel
                {
                    Id = int.Parse(collection["Id"]),
                    Name = collection["Name"],
                    HP = int.Parse(collection["HP"]),
                    Attack = int.Parse(collection["Attack"]),
                    Defense = int.Parse(collection["Defense"]),
                    SpecialAttack = int.Parse(collection["SpecialAttack"]),
                    SpecialDefense = int.Parse(collection["SpecialDefense"]),
                    Speed = int.Parse(collection["Speed"]),
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

        // GET: PokemonController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Data.Instance.pokemonList.Find(pokemon => pokemon.Id == id);
            return View(model);
        }

        // POST: PokemonController/Edit/5
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

        // GET: PokemonController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Data.Instance.pokemonList.Find(pokemon => pokemon.Id == id);
            return View();
        }

        // POST: PokemonController/Delete/5
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
