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
        public static Materia CrearMateriaDePueba(string nombre, string codigo)
        {
            Materia materia = Materia.CrearMateria();
            materia.Nombre = nombre;
            materia.Codigo = codigo;
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

        public static Docente CrearDocenteDePrueba(string nombre, string apellido)
        {
            Docente docente = Docente.CrearDocente();
            docente.Nombre = nombre;
            docente.Apellido = apellido;
            return docente;
        }

        public static ModuloGestionMaterias CrearModuloGestionMateriasDePrueba()
        {
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias moduloGestionMaterias = new ModuloGestionMaterias(repositorio);
            //ModuloGestionMaterias moduloGestionMaterias = ModuloGestionMaterias.ObtenerInstancia(repositorio);
            return moduloGestionMaterias;
        }


    }
}
