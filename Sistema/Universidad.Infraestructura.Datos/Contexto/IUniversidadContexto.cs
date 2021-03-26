using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;

namespace Universidad.Infraestructura.Datos.Contexto
{
    public interface IUniversidadContexto
    {
        DbSet<Administrativo> Administrative { get; set; }
        DbSet<Alumno> Student { get; set; }
        DbSet<Carrera> Race { get; set; }
        DbSet<CicloLectivo> School_Year { get; set; }
        DbSet<Comision> Commission { get; set; }
        DbSet<Cursado> Studied { get; set; }
        DbSet<Inscripcion> Inscription { get; set; }
        DbSet<Materia> Subject { get; set; }
        DbSet<Nivel> Level { get; set; }
        DbSet<Perfil> Profile { get; set; }
        DbSet<Permiso> Permission { get; set; }
        DbSet<Persona> Person { get; set; }
        DbSet<Profesor> Professor { get; set; }
        DbSet<Usuario> User { get; set; }
        DbSet<Modalidad> Modality { get; set; }
        DbSet<Sexo> Sex { get; set; }
    }
}
