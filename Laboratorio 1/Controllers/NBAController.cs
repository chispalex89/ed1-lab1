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
        public ActionResult Details(string id)
        {
            var model = Data.Instance.nbaList.Find(nba => nba.Team == id);
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
                    Team = collection["Equipo"],
                    Center = collection["Base"],
                    PowerForward = collection["Escolta"],
                    SmallForward = collection["Alero"],
                    PointGuard = collection["AlaPivot"],
                    ShootingGuard = collection["Pivot"],
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
        public ActionResult Delete(string id)
        {
            var model = Data.Instance.nbaList.Find(nba => nba.Team == id);
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
