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
    public class PeliculasController : Controller
    {
        // GET: PeliculasController
        public ActionResult Index()
        {
           
            return View(DataPelicula.Instancia.lPeliculas);
        }

        // GET: PeliculasController/Details/5
        public ActionResult Details(string id)
        {
            var modelo = DataPelicula.Instancia.lPeliculas.Find(PeliculaModel => PeliculaModel.Nombre == id);
            return View(modelo);
        }

        // GET: PeliculasController/Create
        public ActionResult Create()
        {
            return View(new PeliculaModel());
        }

        // POST: PeliculasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                PeliculaModel.Guardar(new PeliculaModel
                {
                    ID = int.Parse(collection["ID"]),
                    Nombre = collection["Nombre"],
                    AñoPublicacion = int.Parse(collection["AñoPublicacion"]),
                    Duracion = int.Parse(collection["Duracion"]),
                    Genero = collection["Genero"],
                    Director = collection["Director"],
                    Disponibilidad = Convert.ToBoolean(collection["Disponibilidad"])
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PeliculasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeliculasController/Edit/5
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

        // GET: PeliculasController/Delete/5
        public ActionResult Delete(string id)
        {
            var modelo = DataPelicula.Instancia.lPeliculas.Find(PeliculaModel => PeliculaModel.Nombre == id);
            return View();
        }

        // POST: PeliculasController/Delete/5
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
