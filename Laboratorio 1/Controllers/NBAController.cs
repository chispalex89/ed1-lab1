using Laboratorio_1.Helpers;
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
            return View(Data.Instance.nbaList);
        }

        // GET: NBAController/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.nbaList.Find(nba => nba.Equipo == id);
            return View(model);
        }

        // GET: NBAController/Create
        public ActionResult Create()
        {
            return View(new NBAModel());
        }

        // POST: NBAController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = NBAModel.Save(new NBAModel
                {
                    Equipo = int.Parse(collection["Equipo"]),
                    Base = collection["Base"],
                    Escolta = collection["Escolta"],
                    Alero = collection["Alero"],
                    AlaPivot = collection["AlaPivot"],
                    Pivot = collection["Pivot"],
                });

                if(response)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
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
            var model = Data.Instance.nbaList.Find(nba => nba.Equipo == id);
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
