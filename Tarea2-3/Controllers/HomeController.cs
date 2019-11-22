using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea2_3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var Coches = new List<Models.Coche>
            {
                new Models.Coche{Tipo = "Jeep",Marca = "BMW",Modelo ="X6",Color ="Azul" },
                new Models.Coche{Tipo = "Auto",Marca = "Mercedes",Modelo ="A200",Color ="Blanco" },
                new Models.Coche{Tipo = "Jeep",Marca = "BMW",Modelo ="X6",Color ="Azul" },
                new Models.Coche{Tipo = "Auto",Marca = "Ford",Modelo ="Mustang",Color ="Rojo" },
                };
            return View(Coches);
        }
    }

}