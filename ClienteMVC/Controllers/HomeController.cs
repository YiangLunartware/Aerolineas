using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bienvenid@";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Página de descripción de la aplicación.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";

            return View();
        }
    }
}
