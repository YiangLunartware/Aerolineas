using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClienteMVC.ProxyHistorialPasajero;

namespace ClienteMVC.Controllers
{
    public class PasajeroController : Controller
    {
        //
        // GET: /Pasajero/

        ServicioHistorialPasajeroClient servicioPasajero = new ServicioHistorialPasajeroClient();

        public ActionResult ListaHistorialesPasajeros()
        {
            ViewBag.Lista = servicioPasajero.GetAllHistorialPasajero();
            return View();
        }

        public ActionResult Buscar(FormCollection fc)
        {
            String condicion = fc["condicion"];
            String criterio = fc["criterio"];
            System.DateTime fecIni = Convert.ToDateTime(fc["fecIni"]);
            System.DateTime fecFin = Convert.ToDateTime(fc["fecFin"]);

            if (condicion.Equals("PorNombre"))
            {
                ViewBag.Lista = servicioPasajero.GetHistorialPasajeroXNombrePasajero(criterio, fecIni, fecFin);
            }
            else if (condicion.Equals("PorDNI"))
            {
                ViewBag.Lista = servicioPasajero.GetHistorialPasajeroXDNI(criterio, fecIni, fecFin);
            }

            return View("ListaHistorialesPasajeros");
        }

        public ActionResult HistorialPasajero()
        {
            ViewBag.Hitorial = servicioPasajero.GetAllHistorialPasajero();

            return View();
        }

        public ActionResult BuscarHistPasajero(FormCollection fc)
        {
            String criterio = fc["codPasajero"];
            System.DateTime fecIni = Convert.ToDateTime(fc["fecIni"]);
            System.DateTime fecFin = Convert.ToDateTime(fc["fecFin"]);

            ViewBag.Hitorial = servicioPasajero.GetCantidadVuelosXPasajero(criterio, fecIni, fecFin);
            return View("HistorialPasajero");
        }

    }
}
