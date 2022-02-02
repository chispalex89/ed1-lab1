using Laboratorio_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Controllers
{
    public class Persona5Controller : Controller
    {
        // GET: Persona5Controller
        public ActionResult Index()
        {
            var list = new List<Persona5Model>();
            list.Add(new Persona5Model
            {
                Id = "Fool",
                Name = "Arsène",
                Strenght = 24,
                Magic = 24,
                EnduranceOrVitality = 24,
                Agility = 39,
                Luck = 10,
            });
            return View(list);
        }

        // GET: Persona5Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Persona5Controller/Create
        public ActionResult Create()
        {
            return View(new Persona5Model());
        }

        // POST: Persona5Controller/Create
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

        // GET: Persona5Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Persona5Controller/Edit/5
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

        // GET: Persona5Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Persona5Controller/Delete/5
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
