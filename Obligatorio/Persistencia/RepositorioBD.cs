using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class RepositorioBD : IRepositorio
    {

        //public static void InsertarAlumnos()
        //{
        //    Alumno alumno1 = Alumno.CrearAlumno();
        //    alumno1.Nombre = "NomPrueba";
        //    alumno1.Apellido = "ApePrueba";


        //    using (Contexto contexto = new Contexto())
        //    {
        //        contexto.Alumnos.Add(alumno1);
        //        contexto.SaveChanges();
        //    }
        //}

        public void AgregarAlumno(Alumno alumno)
        {
            using(Contexto contexto = new Contexto())
            {
                contexto.Alumnos.Add(alumno);
                contexto.SaveChanges();
            }
        }

        public void AgregarDocente(Docente docente)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Docentes.Add(docente);
                contexto.SaveChanges();
            }
        }

        public void AgregarMateria(Materia materia)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Materias.Add(materia);
                contexto.SaveChanges();
            }
        }

        public void EliminarAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public void EliminarDocente(Docente docente)
        {
            throw new NotImplementedException();
        }

        public void EliminarMateria(Materia materia)
        {
            throw new NotImplementedException();
        }

        public ICollection<Alumno> ObtenerAlumnos()
        {
            throw new NotImplementedException();
        }

        public ICollection<Materia> ObtenerMaterias()
        {
            throw new NotImplementedException();
        }
    }
}
