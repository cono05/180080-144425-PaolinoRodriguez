using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Pruebas
{
    class UtilidadesPruebas
    {
        public static Materia CrearMateriaDePueba(string nombre)
        {
            Materia materia = Materia.CrearMateria();
            materia.Nombre = nombre;
            return materia;
        }

        public static Alumno CrearAlumnoDePrueba(string nombre, string apellido, string cedula, string mail, int numeroDeEstudiante)
        {
            Alumno alumno = Alumno.CrearAlumno();
            alumno.Nombre = nombre;
            alumno.Apellido = apellido;
            alumno.Cedula = cedula;
            alumno.Mail = mail;
            alumno.NumeroDeEstudiante = numeroDeEstudiante;
            return alumno;
        }

        public static Docente CrearDocente(string nombre, string apellido)
        {
            Docente docente = Docente.CrearDocente();
            docente.Nombre = nombre;
            docente.Apellido = apellido;
            return docente;
        }


    }
}
