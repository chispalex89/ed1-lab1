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
    public class Persona5Controller : Controller
    {
        // GET: Persona5Controller
        public ActionResult Index()
        {
            return View(DataPersona5.Instance.Persona5List);
        }

        // GET: Persona5Controller/Details/5
        public ActionResult Details(string id)
        {
            var model = DataPersona5.Instance.Persona5List.Find(Persona5 => Persona5.Id == id);
            return View(model);
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
                Persona5Model.Save(new Persona5Model
                {
                    Id = (collection["Id"]),
                    Name = collection["Name"],
                    Strenght = int.Parse(collection["Strenght"]),
                    Magic = int.Parse(collection["Magic"]),
                    EnduranceOrVitality = int.Parse(collection["EnduranceOrVitality"]),
                    Agility = int.Parse(collection["Agility"]),
                    Luck = int.Parse(collection["Luck"])
                });
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
        public ActionResult Delete(string id)
        {
            var model = DataPersona5.Instance.Persona5List.Find(Persona5 => Persona5.Id == id);
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
