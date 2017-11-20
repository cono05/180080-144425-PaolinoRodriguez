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

        public void AgregarAlumnoEnMateria(Materia materia, Alumno alumno)
        {
            using (Contexto contexto = new Contexto())
            {
                materia = contexto.Materias.Find(materia.Codigo);
                alumno = contexto.Alumnos.Find(alumno.Id);
                contexto.Materias.Attach(materia);
                contexto.Alumnos.Attach(alumno);
                materia.Alumnos.Add(alumno);
                alumno.MateriasInscripto.Add(materia);

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
    

        public void EliminarAlumno(Alumno unAlumno)
        {
            using (Contexto contexto = new Contexto())
            {
                var alumnoAEliminar = (from alumno in contexto.Alumnos
                                       where alumno.Id == unAlumno.Id
                                       select alumno).Single();

                contexto.Alumnos.Remove(alumnoAEliminar);
                contexto.SaveChanges();
            }
        }

        public void EliminarCamioneta(Camioneta camioneta)
        {
            throw new NotImplementedException();
        }

        public void EliminarDocente(Docente unDocente)
        {
            using (Contexto contexto = new Contexto())
            {
                var doncenteAEliminar = (from docente in contexto.Docentes
                                         where docente.Id == unDocente.Id
                                         select docente).Single();

                contexto.Docentes.Remove(doncenteAEliminar);
                contexto.SaveChanges();
            }
        }

        public void EliminarMateria(Materia unaMateria)
        {
            using (Contexto contexto = new Contexto())
            {
                var materiaAEliminar = (from materia in contexto.Materias
                                        where materia.Codigo == unaMateria.Codigo
                                        select materia).Single();

                contexto.Materias.Remove(materiaAEliminar);
                contexto.SaveChanges();
            }
        }

        public ICollection<Alumno> ObtenerAlumnos()
        {
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Alumnos.Include("MateriasInscripto").ToList();
                return query;
            }
        }

        public ICollection<Camioneta> ObtenerCamionetas()
        {
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Camionetas.ToList();
                return query;
            }
        }

        public ICollection<Docente> ObtenerDocentes()
        {
            ICollection<Docente> retorno;
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Docentes.Include("MateriasQueDicta");
                retorno = query.ToList();
            }
            return retorno;
        }

        public ICollection<Materia> ObtenerMaterias()
        {
            ICollection<Materia> retorno;
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Materias.Include("Alumnos").Include("Docentes");
                retorno = query.ToList();
            }
            return retorno;
        }

        public ICollection<Alumno> ObtenerAlumnosDeLaMateria(Materia materia)
        {
            using (Contexto contexto = new Contexto())
            {
                materia = contexto.Materias.Find(materia.Codigo);
                //alumno = contexto.Alumnos.Find(alumno.Id);
                contexto.Materias.Attach(materia);
                return materia.Alumnos;
                //contexto.Alumnos.Attach(alumno);
                //materia.Alumnos.Add(alumno);
                //alumno.MateriasInscripto.Add(materia);

                //contexto.SaveChanges();
            }
        }

        public ICollection<Docente> ObtenerDocentesDeLaMateria(Materia materia)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Materias.Attach(materia);
                ICollection<Docente> query = contexto.Materias.Find(materia.Codigo).Docentes;
                //alumno = contexto.Alumnos.Find(alumno.Id);
                return query;
                //contexto.Alumnos.Attach(alumno);
                //materia.Alumnos.Add(alumno);
                //alumno.MateriasInscripto.Add(materia);

                //contexto.SaveChanges();
            }
        }

        public void AgregarDocenteEnMateria(Materia materia, Docente docente)
        {
            using (Contexto contexto = new Contexto())
            {
                materia = contexto.Materias.Find(materia.Codigo);
                docente = contexto.Docentes.Find(docente.Id);
                contexto.Materias.Attach(materia);
                contexto.Docentes.Attach(docente);
                materia.Docentes.Add(docente);
                docente.MateriasQueDicta.Add(materia);
                contexto.SaveChanges();
            }
        }

        public void ModificarAlumno(Alumno aCambiar, Alumno nuevosDatos)
        {
            Alumno miAlumno;
            using(Contexto contexto = new Contexto())
            {
                var query = from alumno in contexto.Alumnos
                            where alumno.Id == aCambiar.Id
                            select alumno;

                miAlumno = query.FirstOrDefault();

                contexto.Alumnos.Attach(miAlumno);
                miAlumno.Nombre     = nuevosDatos.Nombre;
                miAlumno.Apellido   = nuevosDatos.Apellido;
                miAlumno.Cedula     = nuevosDatos.Cedula;
                miAlumno.Mail       = nuevosDatos.Mail;
                contexto.SaveChanges();
            }
        }

        public void ModificarDocente(Docente aCambiar, Docente nuevosDatos)
        {
            Docente miDocente;
            using(Contexto contexto = new Contexto())
            {
                var query = from docente in contexto.Docentes
                            where docente.Id == aCambiar.Id
                            select docente;

                miDocente = query.FirstOrDefault();

                contexto.Docentes.Attach(miDocente);
                miDocente.Nombre    = nuevosDatos.Nombre;
                miDocente.Apellido  = nuevosDatos.Apellido;
                miDocente.Cedula    = nuevosDatos.Cedula;
                contexto.SaveChanges();
            }
        }

        public void ModificarMateria(Materia aCambiar, string nuevoNombre)
        {
            Materia miMateria;
            using (Contexto contexto = new Contexto())
            {
                var query = from materia in contexto.Materias
                            where materia.Codigo == aCambiar.Codigo
                            select materia;

                miMateria = query.FirstOrDefault();

                contexto.Materias.Attach(miMateria);
                miMateria.Nombre = nuevoNombre;
                contexto.SaveChanges();
            }
        }
    }
}
