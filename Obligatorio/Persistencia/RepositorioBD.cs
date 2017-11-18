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
        public void AgregarAlumno(Alumno alumno)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Alumnos.Add(alumno);
                contexto.SaveChanges();
            }
        }

        public void AgregarCamioneta(Camioneta camioneta)
        {
            throw new NotImplementedException();
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
            //Alumno miAlumno;
            //using (Contexto contexto = new Contexto())
            //{
            //    IEnumerable<Alumno> query = from AlumnosBD in contexto.Alumnos
            //                                where AlumnosBD.Id == alumno.Id
            //                                select alumno;

            //    miAlumno = query.FirstOrDefault();

            //}
            throw new NotImplementedException();
        }

        public void EliminarCamioneta(Camioneta camioneta)
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

        public ICollection<Camioneta> ObtenerCamionetas()
        {
            throw new NotImplementedException();
        }

        public ICollection<Docente> ObtenerDocentes()
        {
            throw new NotImplementedException();
        }

        public ICollection<Materia> ObtenerMaterias()
        {
            throw new NotImplementedException();
        }
    }
}
