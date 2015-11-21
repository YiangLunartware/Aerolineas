using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cliente.ProxyMigrantes;

namespace Cliente.Controllers
{
    public class MigranteController : Controller
    {
        // GET: Migrante

        ServicioMigrantesClient miServMigrante = new ServicioMigrantesClient();
        
        public ActionResult ConsultaMaxMigrantesNacionalidad()
        {
            ViewBag.ListarPaises = miServMigrante.ListaPaises();
            return View();
        }
        public ActionResult Consultar(FormCollection fc)
        {
            String codPaisNac = fc["codPaisNac"];

            PaisBE p = miServMigrante.ConsultaMaximoMigrantesNacionalidad(codPaisNac);

            ViewBag.NomPais = p.NomPais;
            ViewBag.Moneda = p.Moneda;
            ViewBag.Idioma = p.Idioma;
            ViewBag.CantVuelos = p.CantVuelos;

            return View("ConsultaMaxMigrantesNacionalidad");
        }


        public ActionResult ListaMigrantesNI()
        {
            ViewBag.ListarPaises = miServMigrante.ListaPaises();
            return View();
        }
        public ActionResult ListarMigrantesNI(FormCollection fc)
        {
            String condicion = fc["condicion"];
            String codPaisNac = fc["codPaisNac"];
            String fecI = fc["fecI"];
            String fecF = fc["fecF"];

            if (condicion.Equals("Nacionales"))
            {
                ViewBag.ListarMigrNacional = miServMigrante
                    .ListaMigrantesNacionales(codPaisNac,
                    Convert.ToDateTime(fecI), Convert.ToDateTime(fecF));
            }
            else if (condicion.Equals("Internacionales"))
            {
                ViewBag.ListarMigrInternac = miServMigrante
                    .ListaMigrantesInternacionales(codPaisNac, 
                    Convert.ToDateTime(fecI), Convert.ToDateTime(fecF));
            }

            return View();
        }

        public ActionResult ListaMigrantesOD()
        {
            ViewBag.ListarPaises = miServMigrante.ListaPaises();
            return View();
        }
        public ActionResult ListarMigrantesOD(FormCollection fc)
        {
            ViewBag.ListarPaises = miServMigrante.ListaPaises();

            String codPaisNac = fc["codPaisNac"];
            String codPaisDest = fc["codPaisDest"];
            String fecI = fc["fecI"];
            String fecF = fc["fecF"];

            ViewBag.ListarMigrantes = miServMigrante
                    .ListaMigrantesPaisesFechas(codPaisNac, codPaisDest,
                    Convert.ToDateTime(fecI), Convert.ToDateTime(fecF));

            return View();
        }

        public ActionResult ListaPaisesMigrantes()
        {
            ViewBag.ListarPaises = miServMigrante.ListaPaises();
            return View();
        }
        public ActionResult ListarPaisesMigrantes(FormCollection fc)
        {
            ViewBag.ListarPaises = miServMigrante.ListaPaises();

            String codPaisNac = fc["codPaisNac"];
            String fecI = fc["fecI"];
            String fecF = fc["fecF"];

            ViewBag.ListarPaisesMigrantes = miServMigrante
                    .ListaPaisesMigrantes(codPaisNac, 
                    Convert.ToDateTime(fecI), Convert.ToDateTime(fecF));

            return View();
        }
    }
}