using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universidad.Infraestructura.Datos.Contexto;
using Universidad.Infraestructura.Datos.Servicios.Profesores;
using Universidad.Infraestructura.Datos.UoW;
using Universidad.Presentacion.Web.ViewModels.HomeVM;

namespace Universidad.Presentacion.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}