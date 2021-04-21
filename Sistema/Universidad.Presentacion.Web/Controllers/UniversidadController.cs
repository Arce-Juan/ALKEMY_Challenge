using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universidad.Presentacion.Web.ViewModels.UnversidadVM;

namespace Universidad.Presentacion.Web.Controllers
{
    public class UniversidadController : Controller
    {
        // GET: Universidad
        public ActionResult Index()
        {
            var mensaje = Request["mensaje"] == null ? "" : Request["mensaje"].ToString();

            var model = new IndexViewModel()
            {
                Mensaje = mensaje
            };

            return View(model);
        }
    }
}