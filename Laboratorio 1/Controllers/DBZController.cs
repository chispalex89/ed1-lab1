using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio_1.Helpers;
using Laboratorio_1.Models;


namespace Laboratorio_1.Controllers
{
    public class DBZController : Controller
    {
        // GET: DBZController
        public ActionResult Index()
        {
            return View(DataDBZ.InstanceDBZ.dbzList);
        }

        // GET: DBZController/Details/5
        public ActionResult Details(int id)
        {
            var model = DataDBZ.InstanceDBZ.dbzList.Find(DBZ => DBZ.Id == id);
            return View(model);
        }

        // GET: DBZController/Create
        public ActionResult Create()
        {
            return View(new DBZModel());
        }

        // POST: DBZController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var response = DBZModel.Save(new DBZModel
                {
                    Id = int.Parse(collection["Id"]),
                    Name = collection["Name"],
                    NPower = int.Parse(collection["NPower"]),
                    SpecialAttack = collection["SpecialAttack"]

                });
                if(response)
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

        // GET: DBZController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = DataDBZ.InstanceDBZ.dbzList.Find(dbz => dbz.Id == id);
            return View(model);
        }

        // POST: DBZController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                DBZModel.Edit(id, new DBZModel
                {
                    Id = int.Parse(collection["Id"]),
                    Name = collection["Name"],
                    NPower = int.Parse(collection["NPower"]),
                    SpecialAttack = collection["SpecialAttack"]
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DBZController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = DataDBZ.InstanceDBZ.dbzList.Find(dbz => dbz.Id == id);
            return View();
        }

        // POST: DBZController/Delete/5
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
