namespace Universidad.Infraestructura.Datos.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Universidad.Dominio.Entidades;

    internal sealed class Configuration : DbMigrationsConfiguration<Universidad.Infraestructura.Datos.Contexto.UniversidadContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Contexto.UniversidadContexto context)
        {

            context.School_Year.Add(
                new CicloLectivo()
                {
                    Anio = 2019,
                    FechaDesde = new DateTime(2019, 03, 10),
                    FechaHasta = new DateTime(2019, 12, 10),
                }
            );
            context.School_Year.Add(
                new CicloLectivo()
                {
                    Anio = 2020,
                    FechaDesde = new DateTime(2020, 03, 10),
                    FechaHasta = new DateTime(2020, 12, 10),
                }
            );
            context.School_Year.Add(
                new CicloLectivo()
                {
                    Anio = 2021,
                    FechaDesde = new DateTime(2021, 03, 10),
                    FechaHasta = new DateTime(2021, 12, 10),
                }
            );

            context.Modality.Add(
                new Modalidad()
                {
                    Descripcion = "ANUAL"
                }
            );
            context.Modality.Add(
                new Modalidad()
                {
                    Descripcion = "CUATRIMESTRAL"
                }
            );

            context.Race.Add(
                new Carrera()
                {
                    Nombre = "Ingenieria en Sistemas de Información",
                    ListaComisiones = ObtenerComisionesSistema(),
                    ListaNiveles = ObtenerNivelesSistema()
                }
            );

            context.Race.Add(
                new Carrera()
                {
                    Nombre = "Ingenieria en Civil",
                    ListaComisiones = ObtenerComisionesCivil(),
                    ListaNiveles = ObtenerNivelesCivil()
                }
            );

            context.Profile.Add(new Perfil()
            {
                Nombre = "Alumno",
                ListaPermisos = ObtenerPermisosAlumno()
            });

            context.Profile.Add(new Perfil()
            {
                Nombre = "Administrativo",
                ListaPermisos = ObtenerPermisosAdministrativo()
            }
            );

            var sexoFemenino = new Sexo()
            {
                Descripcion = "Femenino"
            };
            context.Sex.Add(sexoFemenino);

            var sexoMasculino = new Sexo()
            {
                Descripcion = "Masculino"
            };
            context.Sex.Add(sexoMasculino);

            context.Student.Add(
                new Alumno()
                {
                    Legajo = 1001,
                    Persona = new Persona()
                    {
                        Dni = 33764132,
                        Apellido = "ARCE",
                        Nombre = "JUAN EDUARDO",
                        FechaNacimiento = new DateTime(1988, 09, 08),
                        Sexo = sexoMasculino
                    },

                    Usuario = new Usuario()
                    {
                        Nombre = "1001",
                        Contrasena = "111",
                        Activo = true
                    }
                }
            );

            context.Student.Add(
                new Alumno()
                {
                    Legajo = 1002,
                    Persona = new Persona()
                    {
                        Dni = 33222111,
                        Apellido = "ARCE",
                        Nombre = "MILAGROS",
                        FechaNacimiento = new DateTime(1994, 05, 01),
                        Sexo = sexoFemenino
                    },

                    Usuario = new Usuario()
                    {
                        Nombre = "1002",
                        Contrasena = "111",
                        Activo = true
                    }
                }
            );

            context.Student.Add(
                new Alumno()
                {
                    Legajo = 1003,
                    Persona = new Persona()
                    {
                        Dni = 33444555,
                        Apellido = "ARCE",
                        Nombre = "JOSE",
                        FechaNacimiento = new DateTime(1986, 03, 02),
                        Sexo = sexoMasculino
                    },

                    Usuario = new Usuario()
                    {
                        Nombre = "1003",
                        Contrasena = "111",
                        Activo = true
                    }
                }
            );

            context.Student.Add(
                new Alumno()
                {
                    Legajo = 1004,
                    Persona = new Persona()
                    {
                        Dni = 33222111,
                        Apellido = "ARCE",
                        Nombre = "LORENA",
                        FechaNacimiento = new DateTime(1987, 04, 15),
                        Sexo = sexoFemenino
                    },

                    Usuario = new Usuario()
                    {
                        Nombre = "1004",
                        Contrasena = "111",
                        Activo = false
                    }
                }
            );

            context.Administrative.Add(
                new Administrativo()
                {
                    Persona = new Persona()
                    {
                        Dni = 1,
                        Apellido = "ADMININ",
                        Nombre = "ADMININ",
                        FechaNacimiento = new DateTime(1990, 01, 01),
                        Sexo = sexoMasculino
                    },

                    Usuario = new Usuario()
                    {
                        Nombre = "admin",
                        Contrasena = "111",
                        Activo = true
                    }
                }
            );

            context.Administrative.Add(
                new Administrativo()
                {
                    Persona = new Persona()
                    {
                        Dni = 11555666,
                        Apellido = "Nieva",
                        Nombre = "Jorgelina",
                        FechaNacimiento = new DateTime(1980, 01, 01),
                        Sexo = sexoFemenino
                    },

                    Usuario = new Usuario()
                    {
                        Nombre = "nievaj",
                        Contrasena = "111",
                        Activo = true
                    }
                }
            );

            context.Professor.Add(
                new Profesor()
                {
                    Activo = true,
                    Persona = new Persona()
                    {
                        Dni = 22333444,
                        Apellido = "Vicente",
                        Nombre = "Fernando",
                        FechaNacimiento = new DateTime(1980, 05, 05),
                        Sexo = sexoMasculino
                    }
                }
            );

            context.Professor.Add(
                new Profesor()
                {
                    Activo = true,
                    Persona = new Persona()
                    {
                        Dni = 22333444,
                        Apellido = "Araujo",
                        Nombre = "Carlos",
                        FechaNacimiento = new DateTime(1970, 06, 06),
                        Sexo = sexoMasculino
                    }
                }
            );

            context.Professor.Add(
                new Profesor()
                {
                    Activo = true,
                    Persona = new Persona()
                    {
                        Dni = 22333444,
                        Apellido = "Del Prado",
                        Nombre = "Anmgelina",
                        FechaNacimiento = new DateTime(1985, 07, 07),
                        Sexo = sexoFemenino
                    }
                }
            );

            context.Professor.Add(
                new Profesor()
                {
                    Activo = false,
                    Persona = new Persona()
                    {
                        Dni = 22333444,
                        Apellido = "Mansilla",
                        Nombre = "Carolina",
                        FechaNacimiento = new DateTime(1987, 08, 08),
                        Sexo = sexoFemenino
                    }
                }
            );
        }

        #region TODO_PARA_SISTEMAS

        private List<Comision> ObtenerComisionesSistema()
        {
            var ComisionesSistema = new List<Comision>();
            var comision = new Comision()
            {
                NumeroAula = 101,
                Nombre = "1S1"
            };
            ComisionesSistema.Add(comision);
            comision = new Comision()
            {
                NumeroAula = 201,
                Nombre = "2S1"
            };
            ComisionesSistema.Add(comision);
            comision = new Comision()
            {
                NumeroAula = 301,
                Nombre = "3S1"
            };
            ComisionesSistema.Add(comision);
            return ComisionesSistema;
        }

        private List<Materia> ObtenerMateriasNivel_1_Sistema()
        {
            var listadoMaterias = new List<Materia>();
            var materia = new Materia()
            {
                Nombre = "Algoritmos y Estructura de Datos",
                Detalles = "Materia relacionada a algoritmo y estructura de datos"
            };
            listadoMaterias.Add(materia);

            materia = new Materia()
            {
                Nombre = "Arquitectura de Computadoras",
                Detalles = "Materia relacionada a arquitectura de computadoras"
            };
            listadoMaterias.Add(materia);
            return listadoMaterias;
        }

        private List<Materia> ObtenerMateriasNivel_2_Sistema()
        {
            var listadoMaterias = new List<Materia>();
            var materia = new Materia()
            {
                Nombre = "Sintaxis y Semantica de Lenguajes",
                Detalles = "Materia relacionada a sintaxis y semantica de lenguajes"
            };
            listadoMaterias.Add(materia);

            materia = new Materia()
            {
                Nombre = "Paradigmas de Programación",
                Detalles = "Materia relacionada a paradigmas de programación"
            };
            listadoMaterias.Add(materia);
            return listadoMaterias;
        }

        private List<Materia> ObtenerMateriasNivel_3_Sistema()
        {
            var listadoMaterias = new List<Materia>();
            var materia = new Materia()
            {
                Nombre = "Programación Web",
                Detalles = "Materia relacionada a programación web"
            };
            listadoMaterias.Add(materia);

            materia = new Materia()
            {
                Nombre = "Programación de Aplicaciones Distribuidas",
                Detalles = "Materia relacionada a programación de aplicaciones distribuidas"
            };
            listadoMaterias.Add(materia);
            return listadoMaterias;
        }

        private List<Nivel> ObtenerNivelesSistema()
        {
            var nivelesSistema = new List<Nivel>();
            var nivel = new Nivel()
            {
                Numero = 1,
                ListaMaterias = ObtenerMateriasNivel_1_Sistema()
            };
            nivelesSistema.Add(nivel);
            nivel = new Nivel()
            {
                Numero = 2,
                ListaMaterias = ObtenerMateriasNivel_2_Sistema()
            };
            nivelesSistema.Add(nivel);
            nivel = new Nivel()
            {
                Numero = 3,
                ListaMaterias = ObtenerMateriasNivel_3_Sistema()
            };
            nivelesSistema.Add(nivel);
            return nivelesSistema;
        }

        #endregion

        #region TODO_PARA_CIVIL

        private List<Comision> ObtenerComisionesCivil()
        {
            var ComisionesCivil = new List<Comision>();
            var comision = new Comision()
            {
                NumeroAula = 103,
                Nombre = "1C1"
            };
            ComisionesCivil.Add(comision);
            comision = new Comision()
            {
                NumeroAula = 203,
                Nombre = "2C1"
            };
            ComisionesCivil.Add(comision);
            comision = new Comision()
            {
                NumeroAula = 303,
                Nombre = "3C1"
            };
            ComisionesCivil.Add(comision);

            return ComisionesCivil;
        }

        private List<Materia> ObtenerMateriasNivel_1_Civil()
        {
            var listadoMaterias = new List<Materia>();
            var materia = new Materia()
            {
                Nombre = "Construcción I",
                Detalles = "Materia relacionada a construcción I"
            };
            listadoMaterias.Add(materia);

            return listadoMaterias;
        }

        private List<Materia> ObtenerMateriasNivel_2_Civil()
        {
            var listadoMaterias = new List<Materia>();
            var materia = new Materia()
            {
                Nombre = "Arquitectura General",
                Detalles = "Materia relacionada a arquitectura general"
            };
            listadoMaterias.Add(materia);

            return listadoMaterias;
        }

        private List<Materia> ObtenerMateriasNivel_3_Civil()
        {
            var listadoMaterias = new List<Materia>();
            var materia = new Materia()
            {
                Nombre = "Construccion III",
                Detalles = "Materia relacionada a construccion III"
            };
            listadoMaterias.Add(materia);
            return listadoMaterias;
        }

        private List<Nivel> ObtenerNivelesCivil()
        {
            var nivelesCivil = new List<Nivel>();
            var nivel = new Nivel()
            {
                Numero = 1,
                ListaMaterias = ObtenerMateriasNivel_1_Civil()
            };
            nivelesCivil.Add(nivel);
            nivel = new Nivel()
            {
                Numero = 2,
                ListaMaterias = ObtenerMateriasNivel_2_Civil()
            };
            nivelesCivil.Add(nivel);
            nivel = new Nivel()
            {
                Numero = 3,
                ListaMaterias = ObtenerMateriasNivel_3_Civil()
            };
            nivelesCivil.Add(nivel);
            return nivelesCivil;
        }

        #endregion

        #region PERFILES_USUARIO

        private List<Permiso> ObtenerPermisosAlumno()
        {
            var listadoPermisos = new List<Permiso>();
            listadoPermisos.Add(
                new Permiso()
                {
                    Nombre = "gestionInscripcionMateria"
                }
            );
            listadoPermisos.Add(
                new Permiso()
                {
                    Nombre = "verListadoInscripcionesPorAlumno"
                }
            );

            return listadoPermisos;
        }

        private List<Permiso> ObtenerPermisosAdministrativo()
        {
            var listadoPermisos = new List<Permiso>();
            listadoPermisos.Add(
                new Permiso()
                {
                    Nombre = "verListadoMateria"
                }
            );
            listadoPermisos.Add(
                new Permiso()
                {
                    Nombre = "verListadoProfesores"
                }
            );
            listadoPermisos.Add(
                new Permiso()
                {
                    Nombre = "verListadoInscripciones"
                }
            );
            listadoPermisos.Add(
                new Permiso()
                {
                    Nombre = "gestionMateria"
                }
            );
            listadoPermisos.Add(
                new Permiso()
                {
                    Nombre = "gestionProfesor"
                }
            );

            return listadoPermisos;
        }

        #endregion

    }
}
