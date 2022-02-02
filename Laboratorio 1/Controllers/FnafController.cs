using Laboratorio_1.Models;

using Microsoft.AspNetCore.Http;
using Laboratorio_1.Helpers;
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
           

            return View(Data.Instance.fnafList);
        }

        // GET: FnafController/Details/5
        public ActionResult Details(string id)
        {
            var model = Data.Instance.fnafList.Find(fnaf => fnaf.Game == id);

            return View(model);
        }

        // GET: FnafController/Create
        public ActionResult Create()
        {
            return View(new FnafModel());
        }

        // POST: FnafController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = FnafModel.Save(new FnafModel
                {
                    Game = (collection["Game"]),
                    Name = collection["Name"],
                    Speed = int.Parse(collection["Speed"]),
                    Attack = int.Parse(collection["Attack"]),
                    Frecuency = int.Parse(collection["Frecuency"])
                });

                if (response)
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

        // GET: FnafController/Edit/5
        public ActionResult Edit(string id)
        {
            var model = Data.Instance.fnafList.Find(fnaf => fnaf.Game == id);

            return View(model);
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
        public ActionResult Delete(string id)
        {
            var model = Data.Instance.fnafList.Find(fnaf => fnaf.Game == id);
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
