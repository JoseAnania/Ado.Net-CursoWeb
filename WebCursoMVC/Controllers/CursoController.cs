using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCursoMVC.Models;

namespace WebCursoMVC.Controllers
{
    public class CursoController : Controller
    {
        // GET: Curso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            Curso C = new Curso();
            return View(C);
        }
        [HttpPost]
        public ActionResult Agregar(Curso nuevoCurso)
        {

            new GestorCurso().Agregar(nuevoCurso);
            return View("Index");
        }
        public ActionResult Listar()
        {
            List<Curso> lista = new GestorCurso().Listar();
            return View(lista);
        }
    }
}
