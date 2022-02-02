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
            var lPeliculas = new List<PeliculaModel>();
            lPeliculas.Add(new PeliculaModel
            {
                Nombre = "1917",
                AñoPublicacion = 2019,
                Duracion = 119,
                Genero = "Suspenso",
                Director = "Sam Mendez",
                Disponibilidad = true
            });
            lPeliculas.Add(new PeliculaModel
            {
                Nombre = "Truman Show: historia de una vida",
                AñoPublicacion = 1998,
                Duracion = 103,
                Genero = "Comedia Dramática",
                Director = "Peter Weir",
                Disponibilidad = false
            });
            return View(lPeliculas);
        }

        // GET: PeliculasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeliculasController/Create
        public ActionResult Create()
        {
            return View(new PokemonModel());
        }

        // POST: PeliculasController/Create
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
        public ActionResult Delete(int id)
        {
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
