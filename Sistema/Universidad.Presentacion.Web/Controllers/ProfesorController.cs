using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Universidad.Dominio.Entidades;
using Universidad.Infraestructura.Datos.Contexto;
using Universidad.Infraestructura.Datos.Servicios.Personas;
using Universidad.Infraestructura.Datos.Servicios.Profesores;
using Universidad.Infraestructura.Datos.Servicios.Sexos;
using Universidad.Infraestructura.Datos.UoW;
using Universidad.Presentacion.Web.ViewModels.ProfesorVM;

namespace Universidad.Presentacion.Web.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly IProfesorServicio _profesorServicio;
        private readonly ISexoServicio _sexoServicio;
        private readonly IPersonaServicio _personaServicio;

        public ProfesorController(
            //UniversidadContexto _context,
            IProfesorServicio profesorServicio,
            ISexoServicio sexoServicio,
            IPersonaServicio personaServicio
        )
        {
            //UnitOfWork _unitOfWork = new UnitOfWork(_context);
            _profesorServicio = profesorServicio;
            _sexoServicio = sexoServicio;
            _personaServicio = personaServicio;
        }

        public ActionResult Index()
        {
            var auz = _profesorServicio.ObtenerTodos().ToList();
            var model = new IndexViewModel()
            {
                Profesores = _profesorServicio.ObtenerTodos().ToList()
            };
            return View(model);
        }

        public ActionResult Gestion(string id, string tipoGestion)
        {
            if (!int.TryParse(id, out int idProfesor) || (tipoGestion != "Nuevo" && tipoGestion != "Modificar"))
                return RedirectToAction("Index", "Universidad", new { mensaje = "Acceso no valido"});

            var model = new GestionViewModel()
            {
                TipoGestion = tipoGestion,
                Sexos = _sexoServicio.ObtenerTodos().Select( x =>
                    new SelectListItem()
                    {
                        Value = x.Id.ToString(),
                        Text = x.Descripcion
                    }
                )
            };

            switch (tipoGestion)
            {
                case "Nuevo":
                    model.Profesor = new Profesor();
                    model.Profesor.Persona = new Persona();
                    model.Profesor.Id = 0;
                    model.Profesor.Activo = true;
                    model.TxtSexo = "1";
                    break;
                case "Modificar":
                    model.Profesor = _profesorServicio.ObtenerPorId(idProfesor);
                    model.TxtDni = model.Profesor.Persona.Dni.ToString();
                    model.TxtApellido = model.Profesor.Persona.Apellido;
                    model.TxtNombre = model.Profesor.Persona.Nombre;
                    model.TxtNacimiento = model.Profesor.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                    break;
                default:
                    return RedirectToAction("Index", "Universidad", new { mensaje = "Acceso no valido" });
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Gestion(GestionViewModel model, FormCollection collection)
        {
            var tipoGestion = collection["nHiddenTipoGestion"];
            var id = collection["nHiddenId"];


            if (!int.TryParse(id, out int idProfesor) || (tipoGestion != "Nuevo" && tipoGestion != "Modificar"))
                return RedirectToAction("Index", "Universidad", new { mensaje = "Acceso no valido" });

            model.TipoGestion = tipoGestion;
            model.Sexos = _sexoServicio.ObtenerTodos().Select(x =>
                new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = x.Descripcion
                }
            );
            

            switch (tipoGestion)
            {
                case "Nuevo":
                    model.Profesor = new Profesor();
                    model.Profesor.Persona = new Persona();
                    model.Profesor.Id = 0;
                    model.Profesor.Activo = true;
                    model.TxtSexo = "1";
                    break;
                case "Modificar":
                    var persona = _personaServicio.ObtenerCompleto(6);
                    persona.Sexo = _sexoServicio.ObtenerPorId(int.Parse(model.TxtSexo));
                    _personaServicio.Modificar(persona);
                    break;
            }
            /*
            if (!ModelState.IsValid)
                return View(model);

            model.Profesor.Persona.Dni = int.Parse(model.TxtDni);
            model.Profesor.Persona.Apellido = model.TxtApellido;
            model.Profesor.Persona.Nombre = model.TxtNombre;
            model.Profesor.Persona.FechaNacimiento = DateTime.Parse(model.TxtNacimiento);
            model.Profesor.Persona.Sexo = _sexoServicio.ObtenerPorId(int.Parse(model.TxtSexo));
            model.Profesor.Activo = model.TxtActivo == "SI"? true : false;

            switch (tipoGestion)
            {
                case "Nuevo":
                    _profesorServicio.AgragarProfesor(model.Profesor);
                    break;
                case "Modificar":
                    _profesorServicio.ModificarProfesor(model.Profesor);
                    break;
                default:
                    return RedirectToAction("Index", "Universidad", new { mensaje = "Acceso no valido" });
            }
            */
            return RedirectToAction("Index", "Profesor");
        }
    }
}