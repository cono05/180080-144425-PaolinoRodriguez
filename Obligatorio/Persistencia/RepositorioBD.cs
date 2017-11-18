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
            using (Contexto contexto = new Contexto())
            {
                contexto.Alumnos.Remove(alumno);
                contexto.SaveChanges();
            }
        }

        public void EliminarCamioneta(Camioneta camioneta)
        {
            throw new NotImplementedException();
        }

        public void EliminarDocente(Docente docente)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Docentes.Remove(docente);
                contexto.SaveChanges();
            }
        }

        public void EliminarMateria(Materia materia)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Materias.Remove(materia);
                contexto.SaveChanges();
            }
        }

        public ICollection<Alumno> ObtenerAlumnos()
        {
            ICollection<Alumno> retorno;
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Alumnos.ToList();
                retorno = query.ToList();
            }
            return retorno;
        }

        public ICollection<Camioneta> ObtenerCamionetas()
        {
            throw new NotImplementedException();
        }

        public ICollection<Docente> ObtenerDocentes()
        {
            ICollection<Docente> retorno;
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Docentes.ToList();
                retorno = query.ToList();
            }
            return retorno;
        }

        public ICollection<Materia> ObtenerMaterias()
        {
            ICollection<Materia> retorno;
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Materias.ToList();
                retorno = query.ToList();
            }
            return retorno;
        }
    }
}
