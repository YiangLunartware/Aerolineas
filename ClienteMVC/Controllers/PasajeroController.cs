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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaHistorialesPasajeros()
        {
            ViewBag.Lista = servicioPasajero.GetAllHistorialPasajero();
            return View();
        }

        public ActionResult Buscar(FormCollection fc)
        {
            String condicion = fc["condicion"];
            String criterio = fc["criterio"];

            if (condicion.Equals("Todas"))
            {
                ViewBag.Lista = servicioPasajero.GetAllHistorialPasajero();
            }
            else
            {
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
            }

            return View("ListaHistorialesPasajeros");
        }

        public ActionResult HistorialPasajero()
        {
            ViewBag.Historial = servicioPasajero.GetAllHistorialPasajero();

            ViewBag.DatosPasajero = new ProxyHistorialPasajero.Pasajero();
            ViewBag.DatosPasajero.NomPasajero = "";
            ViewBag.DatosPasajero.DNI = "";
            ViewBag.DatosPasajero.Email = "";
            ViewBag.DatosPasajero.NumTelefono = "";
            ViewBag.DatosPasajero.Nacionalidad = "";
            ViewBag.DatosPasajero.Genero = "";
            ViewBag.DatosPasajero.CantVuelos = 0;

            return View();
        }

        public ActionResult BuscarHistPasajero(FormCollection fc)
        {
            String criterio = fc["codPasajero"];
            System.DateTime fecIni = Convert.ToDateTime(fc["fecIni"]);
            System.DateTime fecFin = Convert.ToDateTime(fc["fecFin"]);

            List<ProxyHistorialPasajero.Pasajero> lista = new List<Pasajero>();
            lista = servicioPasajero.GetCantidadVuelosXPasajero(criterio, fecIni, fecFin);

            ViewBag.Historial = lista;
            ViewBag.DatosPasajero = lista.First();

            ViewBag.DatosPasajero.NomPasajero = lista.First().NomPasajero;
            ViewBag.DatosPasajero.DNI = lista.First().DNI;
            ViewBag.DatosPasajero.Email = lista.First().Email;
            ViewBag.DatosPasajero.NumTelefono = lista.First().NumTelefono;
            ViewBag.DatosPasajero.Nacionalidad = lista.First().Nacionalidad;
            ViewBag.DatosPasajero.Genero = lista.First().Genero;
            ViewBag.DatosPasajero.CantVuelos = lista.First().CantVuelos;

            return View("HistorialPasajero");
        }

    }
}
