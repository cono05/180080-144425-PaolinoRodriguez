using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Logica;
using Persistencia;

namespace Pruebas
{
    class UtilidadesPruebas
    {
        public static void VaciarTablas()
        {
            //Database.SetInitializer<Contexto>(null);
            using (var contexto = new Contexto())
            {
                var alumnos = (from alumno in contexto.Alumnos select alumno);
                foreach (Alumno alumno in alumnos)
                {

                    contexto.Alumnos.Remove(alumno);
                }

                var docentes = (from docente in contexto.Docentes
                                select docente);
                foreach (Docente docente in docentes)
                {
                    contexto.Docentes.Remove(docente);
                }

                var materias = (from materia in contexto.Materias
                                select materia);
                foreach (Materia materia in materias)
                {
                    contexto.Materias.Remove(materia);
                }
                contexto.SaveChanges();
            }
        }

        public static RepositorioBD CrearRepositorioBDPrueba()
        {
            RepositorioBD repositorio = new RepositorioBD();
            return repositorio;
        }
        public static RepositorioRam CrearRepositorioRamDePrueba()
        {
            RepositorioRam repositorio = new RepositorioRam();
            return repositorio;
        }
        public static Materia CrearMateriaDePueba(string nombre, int codigo)
        {
            Materia materia = Materia.CrearMateria();
            materia.Nombre = nombre;
            //materia.Codigo = codigo;
            return materia;
        }

        public static Alumno CrearAlumnoDePrueba(string nombre, string apellido, string cedula, string mail, int numeroDeEstudiante)
        {
            Alumno alumno = Alumno.CrearAlumno();
            alumno.Nombre = nombre;
            alumno.Apellido = apellido;
            alumno.Cedula = cedula;
            alumno.Mail = mail;
            return alumno;
        }

        public static Docente CrearDocenteDePrueba(string nombre, string apellido, string cedula)
        {
            Docente docente = Docente.CrearDocente();
            docente.Nombre = nombre;
            docente.Apellido = apellido;
            docente.Cedula = cedula;
            return docente;
        }

        public static Actividad CrearActividadDePrueba(string nombre, DateTime fecha, decimal costo)
        {
            Actividad actividad = Actividad.CrearActividad();
            actividad.Nombre = nombre;
            actividad.Fecha = fecha;
            actividad.Costo = costo;
            return actividad;
        }

        public static Camioneta CrearCamionetaDePrueba(string marca, string chapa, int capacidad)
        {
            Camioneta camioneta = Camioneta.CrearCamioneta();
            camioneta.Marca = marca;
            camioneta.Chapa = chapa;
            camioneta.Capacidad = capacidad;
            return camioneta;
        }

        public static ModuloGestionMaterias CrearModuloGestionMateriasDePrueba(ref RepositorioRam repositorio)
        {
            ModuloGestionMaterias moduloGestionMaterias = new ModuloGestionMaterias(repositorio);
            //ModuloGestionMaterias moduloGestionMaterias = ModuloGestionMaterias.ObtenerInstancia(ref repositorio);
            return moduloGestionMaterias;
        }

        public static ModuloGestionAlumno CrearModuloGestionAlumnosDePrueba(ref RepositorioRam repositorio)
        {
            ModuloGestionAlumno moduloGestionAlumnos = new ModuloGestionAlumno(repositorio);
            return moduloGestionAlumnos;
        }

        public static ModuloGestionDocente CrearModuloGestionDocentesDePrueba(ref RepositorioRam repositorio)
        {
            ModuloGestionDocente moduloGestionDocentes = new ModuloGestionDocente(repositorio);
            return moduloGestionDocentes;
        }

        public static ModuloGestionCamioneta CrearModuloGestionCamionetaDePrueba(ref RepositorioRam repositorio)
        {
            ModuloGestionCamioneta moduloGestionCamionetas = new ModuloGestionCamioneta(repositorio);
            return moduloGestionCamionetas;
        }

        public static ModuloGestionActividad CrearModuloGestionActividadDePrueba(IRepositorio repositorio)
        {
            ModuloGestionActividad moduloGestionActividad = new ModuloGestionActividad(repositorio);
            return moduloGestionActividad;
        }

   }
}
