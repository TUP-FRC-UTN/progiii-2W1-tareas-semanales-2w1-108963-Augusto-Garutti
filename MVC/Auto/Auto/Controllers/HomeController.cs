using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auto.Models;

namespace Auto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Alta(FormCollection form)
        {
            string patente = form["patente"];
            int idMarca = Int32.Parse(form["idMarca"]); 
            int km = Int32.Parse(form["km"]);
            bool promocion = bool.Parse(form["promocion"]);//Estoy teniedo para cargar el bool , me podria indicar donde esta el errror?
            float precio = float.Parse(form["precio"]);

            Autos a = new Autos(0, patente, idMarca, km,promocion, precio);
            ConexionBD c = new ConexionBD();
            return View("Listado", a);
        }
        public ActionResult Alta()
        {
            ConexionBD c = new ConexionBD();
            return View(c.ListaMarcas());
        }
    }
}