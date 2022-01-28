using Laboratorio_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Laboratorio_1.Controllers
{
    public class FnafController : Controller
    {
        // GET: FnafController
        public ActionResult Index()
        {
            var list = new List<FnafModel>();

            list.Add(new FnafModel
            {
                Game = "FNAF 1",
                Name = "Freddy Fazbear",
                Frecuency = 20,
                Attack = 100,
                Speed = 10,

            });
            return View(list);
        }

        // GET: FnafController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FnafController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FnafController/Create
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

        // GET: FnafController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FnafController/Edit/5
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

        // GET: FnafController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FnafController/Delete/5
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
