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
    public class DogController : Controller
    {
        // GET: DogController
        public ActionResult Index()
        {
            return View(Data.Instance.DogList);
        }

        // GET: DogController/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.DogList.Find(dog => dog.Id == id);
            return View(model);
        }

        // GET: DogController/Create
        public ActionResult Create()
        {
            return View(new Dogmodel());
        }

        // POST: DogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = Dogmodel.Save(new Dogmodel
                {
                    Id = int.Parse(collection["Id"]),
                    Name = collection["Name"],
                    Race = collection["Race"],
                    Weight = int.Parse(collection["Weight"]),
                    Height = int.Parse(collection["Height"])
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Data.Instance.DogList.Find(dog => dog.Id == id);
            return View(model);
        }

        // POST: DogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Dogmodel.Edit(id, new Dogmodel
                {
                    Name = collection["Name"],
                    Race = collection["Race"],
                    Weight = int.Parse(collection["Weight"]),
                    Height = int.Parse(collection["Height"])
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DogController/Delete/5
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
