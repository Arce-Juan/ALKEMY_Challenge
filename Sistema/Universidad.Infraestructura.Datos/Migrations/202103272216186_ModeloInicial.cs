namespace Universidad.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrative",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Persona_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Persona_Id)
                .ForeignKey("dbo.User", t => t.Usuario_Id)
                .Index(t => t.Persona_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dni = c.Int(nullable: false),
                        Apellido = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Sexo_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sex", t => t.Sexo_Id, cascadeDelete: true)
                .Index(t => t.Sexo_Id);
            
            CreateTable(
                "dbo.Sex",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Contrasena = c.String(),
                        Activo = c.Boolean(nullable: false),
                        Perfil_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.Perfil_Id)
                .Index(t => t.Perfil_Id);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        PerfilId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.PerfilId, cascadeDelete: true)
                .Index(t => t.PerfilId);
            
            CreateTable(
                "dbo.Commission",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroAula = c.Int(nullable: false),
                        Nombre = c.String(),
                        Carrera_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Race", t => t.Carrera_Id)
                .Index(t => t.Carrera_Id);
            
            CreateTable(
                "dbo.Race",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Level",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        CarreraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Race", t => t.CarreraId, cascadeDelete: true)
                .Index(t => t.CarreraId);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Detalles = c.String(),
                        NivelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Level", t => t.NivelId, cascadeDelete: true)
                .Index(t => t.NivelId);
            
            CreateTable(
                "dbo.Inscription",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        CursadoId = c.Int(nullable: false),
                        Alumno_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Student", t => t.Alumno_Id)
                .ForeignKey("dbo.Studied", t => t.CursadoId, cascadeDelete: true)
                .Index(t => t.CursadoId)
                .Index(t => t.Alumno_Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Legajo = c.Int(nullable: false),
                        Persona_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Persona_Id)
                .ForeignKey("dbo.User", t => t.Usuario_Id)
                .Index(t => t.Persona_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Studied",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CupoMaximo = c.Int(nullable: false),
                        CupoActual = c.Int(nullable: false),
                        Administrativo_Id = c.Int(),
                        Ciclo_Id = c.Int(),
                        Comision_Id = c.Int(),
                        Materia_Id = c.Int(),
                        Modalidad_Id = c.Int(),
                        Profesor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administrative", t => t.Administrativo_Id)
                .ForeignKey("dbo.School_Year", t => t.Ciclo_Id)
                .ForeignKey("dbo.Commission", t => t.Comision_Id)
                .ForeignKey("dbo.Subject", t => t.Materia_Id)
                .ForeignKey("dbo.Modality", t => t.Modalidad_Id)
                .ForeignKey("dbo.Professor", t => t.Profesor_Id)
                .Index(t => t.Administrativo_Id)
                .Index(t => t.Ciclo_Id)
                .Index(t => t.Comision_Id)
                .Index(t => t.Materia_Id)
                .Index(t => t.Modalidad_Id)
                .Index(t => t.Profesor_Id);
            
            CreateTable(
                "dbo.School_Year",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Anio = c.Int(nullable: false),
                        FechaDesde = c.DateTime(nullable: false),
                        FechaHasta = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modality",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Activo = c.Boolean(nullable: false),
                        Persona_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Persona_Id, cascadeDelete: true)
                .Index(t => t.Persona_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Studied", "Profesor_Id", "dbo.Professor");
            DropForeignKey("dbo.Professor", "Persona_Id", "dbo.Person");
            DropForeignKey("dbo.Studied", "Modalidad_Id", "dbo.Modality");
            DropForeignKey("dbo.Studied", "Materia_Id", "dbo.Subject");
            DropForeignKey("dbo.Inscription", "CursadoId", "dbo.Studied");
            DropForeignKey("dbo.Studied", "Comision_Id", "dbo.Commission");
            DropForeignKey("dbo.Studied", "Ciclo_Id", "dbo.School_Year");
            DropForeignKey("dbo.Studied", "Administrativo_Id", "dbo.Administrative");
            DropForeignKey("dbo.Inscription", "Alumno_Id", "dbo.Student");
            DropForeignKey("dbo.Student", "Usuario_Id", "dbo.User");
            DropForeignKey("dbo.Student", "Persona_Id", "dbo.Person");
            DropForeignKey("dbo.Subject", "NivelId", "dbo.Level");
            DropForeignKey("dbo.Level", "CarreraId", "dbo.Race");
            DropForeignKey("dbo.Commission", "Carrera_Id", "dbo.Race");
            DropForeignKey("dbo.Administrative", "Usuario_Id", "dbo.User");
            DropForeignKey("dbo.User", "Perfil_Id", "dbo.Profile");
            DropForeignKey("dbo.Permission", "PerfilId", "dbo.Profile");
            DropForeignKey("dbo.Administrative", "Persona_Id", "dbo.Person");
            DropForeignKey("dbo.Person", "Sexo_Id", "dbo.Sex");
            DropIndex("dbo.Professor", new[] { "Persona_Id" });
            DropIndex("dbo.Studied", new[] { "Profesor_Id" });
            DropIndex("dbo.Studied", new[] { "Modalidad_Id" });
            DropIndex("dbo.Studied", new[] { "Materia_Id" });
            DropIndex("dbo.Studied", new[] { "Comision_Id" });
            DropIndex("dbo.Studied", new[] { "Ciclo_Id" });
            DropIndex("dbo.Studied", new[] { "Administrativo_Id" });
            DropIndex("dbo.Student", new[] { "Usuario_Id" });
            DropIndex("dbo.Student", new[] { "Persona_Id" });
            DropIndex("dbo.Inscription", new[] { "Alumno_Id" });
            DropIndex("dbo.Inscription", new[] { "CursadoId" });
            DropIndex("dbo.Subject", new[] { "NivelId" });
            DropIndex("dbo.Level", new[] { "CarreraId" });
            DropIndex("dbo.Commission", new[] { "Carrera_Id" });
            DropIndex("dbo.Permission", new[] { "PerfilId" });
            DropIndex("dbo.User", new[] { "Perfil_Id" });
            DropIndex("dbo.Person", new[] { "Sexo_Id" });
            DropIndex("dbo.Administrative", new[] { "Usuario_Id" });
            DropIndex("dbo.Administrative", new[] { "Persona_Id" });
            DropTable("dbo.Professor");
            DropTable("dbo.Modality");
            DropTable("dbo.School_Year");
            DropTable("dbo.Studied");
            DropTable("dbo.Student");
            DropTable("dbo.Inscription");
            DropTable("dbo.Subject");
            DropTable("dbo.Level");
            DropTable("dbo.Race");
            DropTable("dbo.Commission");
            DropTable("dbo.Permission");
            DropTable("dbo.Profile");
            DropTable("dbo.User");
            DropTable("dbo.Sex");
            DropTable("dbo.Person");
            DropTable("dbo.Administrative");
        }
    }
}
