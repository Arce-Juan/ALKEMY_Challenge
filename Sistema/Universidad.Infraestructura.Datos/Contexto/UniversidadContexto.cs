using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Dominio.Entidades;

namespace Universidad.Infraestructura.Datos.Contexto
{
    public class UniversidadContexto : DbContext, IUniversidadContexto
    {
        public UniversidadContexto() : base("name=UniversityConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Administrativo>()
                .ToTable("Administrative");
            modelBuilder.Entity<Alumno>()
                .ToTable("Student");
            modelBuilder.Entity<Carrera>()
                .ToTable("Race");
            modelBuilder.Entity<CicloLectivo>()
                .ToTable("School_Year");
            modelBuilder.Entity<Comision>()
                .ToTable("Commission");
            modelBuilder.Entity<Cursado>()
                .ToTable("Studied");
            modelBuilder.Entity<Inscripcion>()
                .ToTable("Inscription");
            modelBuilder.Entity<Materia>()
                .ToTable("Subject");
            modelBuilder.Entity<Nivel>()
                .ToTable("Level");
            modelBuilder.Entity<Perfil>()
                .ToTable("Profile");
            modelBuilder.Entity<Permiso>()
                .ToTable("Permission");
            modelBuilder.Entity<Persona>()
                .ToTable("Person");
            modelBuilder.Entity<Profesor>()
                .ToTable("Professor");
            modelBuilder.Entity<Usuario>()
                .ToTable("User");
            modelBuilder.Entity<Modalidad>()
                .ToTable("Modality");
            modelBuilder.Entity<Sexo>()
                .ToTable("Sex");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Administrativo> Administrative { get; set; }
        public DbSet<Alumno> Student { get; set; }
        public DbSet<Carrera> Race { get; set; }
        public DbSet<CicloLectivo> School_Year { get; set; }
        public DbSet<Comision> Commission { get; set; }
        public DbSet<Cursado> Studied { get; set; }
        public DbSet<Inscripcion> Inscription { get; set; }
        public DbSet<Materia> Subject { get; set; }
        public DbSet<Nivel> Level { get; set; }
        public DbSet<Perfil> Profile { get; set; }
        public DbSet<Permiso> Permission { get; set; }
        public DbSet<Persona> Person { get; set; }
        public DbSet<Profesor> Professor { get; set; }
        public DbSet<Usuario> User { get; set; }
        public DbSet<Modalidad> Modality { get; set; }
        public DbSet<Sexo> Sex { get; set; }

    }
}
