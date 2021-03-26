using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universidad.Infraestructura.Datos.Contexto;
using Universidad.Infraestructura.Datos.Servicios.Profesores;
using Universidad.Infraestructura.Datos.UoW;

namespace Universidad.Presentacion.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProfesorServicio _profesorServicio;

        public HomeController(IProfesorServicio profesorServicio, UniversidadContexto _context)
        {
            UnitOfWork _unitOfWork = new UnitOfWork(_context);
            _profesorServicio = profesorServicio;
        }

        public ActionResult Index()
        {
            var datos = _profesorServicio.ObtenerProfesoresActivos(true);
            return View();
        }

        public ActionResult Prueba()
        {
            var datos = _profesorServicio.ObtenerProfesoresActivos(true);
            return View();
        }

    }
}