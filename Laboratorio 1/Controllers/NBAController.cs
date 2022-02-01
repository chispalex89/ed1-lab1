using Laboratorio_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Laboratorio_1.Controllers
{
    public class NBAController : Controller
    {
        // GET: NBAController
        public ActionResult Index()
        {
            var list = new List<NBAModel>
            {
                new NBAModel
                {
                    Equipo = "Brooklyn Nets",
                    Base = "James Harden",
                    Escolta = "Blake Griffin",
                    Alero = "Kyrie Irving",
                    AlaPivot = "Kevin Durant",
                    Pivot = "Nicolas Claxton"
                }
            };
            return View(list);
        }

        // GET: NBAController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NBAController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NBAController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: NBAController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NBAController/Edit/5
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

        // GET: NBAController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NBAController/Delete/5
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
