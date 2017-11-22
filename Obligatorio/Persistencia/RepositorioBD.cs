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

        public void EliminarAlumnoDeMateria(Materia materia, Alumno alumno)
        {
            using (Contexto contexto = new Contexto())
            {
                materia = contexto.Materias.Find(materia.Codigo);
                alumno = contexto.Alumnos.Find(alumno.Id);
                contexto.Materias.Attach(materia);
                contexto.Alumnos.Attach(alumno);
                materia.Alumnos.Remove(alumno);
                alumno.MateriasInscripto.Remove(materia);

                contexto.SaveChanges();
            }
        }

        public void AgregarCamioneta(Camioneta camioneta)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Camionetas.Add(camioneta);
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

        public void EliminarCamioneta(Camioneta unaCamioneta)
        {
            using (Contexto contexto = new Contexto())
            {
                var camionetaAEliminar = (from camioneta in contexto.Camionetas
                                         where camioneta.Chapa == unaCamioneta.Chapa
                                         select camioneta).Single();

                contexto.Camionetas.Remove(camionetaAEliminar);
                contexto.SaveChanges();
            }
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

        public void EliminarActividad(Actividad unaActividad)
        {
            using (Contexto contexto = new Contexto())
            {
                var actividadAEliminar = (from actividad in contexto.Actividades
                                          where actividad.Id == unaActividad.Id
                                          select actividad).Single();

                contexto.Actividades.Remove(actividadAEliminar);
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

        public Materia ObtenerMateriaPorCodigo(int codigo)
        {
            using (Contexto contexto = new Contexto())
            {
                var materia = contexto.Materias.Find(codigo);
                return materia;
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
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Materias.Include("Alumnos").Include("Docentes").ToList();
                return query;
            }
            //ICollection<Materia> retorno;
            //using (Contexto contexto = new Contexto())
            //{
            //    var query = contexto.Materias.Include("Alumnos").Include("Docentes");
            //    retorno = query.ToList();
            //}
            //return retorno;
        }

        public ICollection<Alumno> ObtenerAlumnosDeLaMateria(Materia materia)
        {
            using (Contexto contexto = new Contexto())
            {
                materia = contexto.Materias.Find(materia.Codigo);
                contexto.Materias.Attach(materia);
                return materia.Alumnos;
                
            }
        }

        public ICollection<Docente> ObtenerDocentesDeLaMateria(Materia materia)
        {
            using (Contexto contexto = new Contexto())
            {
                materia = contexto.Materias.Find(materia.Codigo);
                contexto.Materias.Attach(materia);
                return materia.Docentes;
            }
        }

        public ICollection<Actividad> ObtenerActividades()
        {
            ICollection<Actividad> retorno;
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Actividades.Include("Participantes").ToList();
                retorno = query;
            }
            return retorno;
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

        public void AgregarParticipanteEnActividad(Actividad actividad, Alumno alumno)
        {
            using (Contexto contexto = new Contexto())
            {
                actividad = contexto.Actividades.Find(actividad.Id);
                alumno = contexto.Alumnos.Find(alumno.Id);
                actividad.Participantes.Add(alumno);
                alumno.ActividadesInscripto.Add(actividad);
                contexto.Actividades.Attach(actividad);
                contexto.Alumnos.Attach(alumno);

                contexto.SaveChanges();
            }
        }

        public void EliminarDocenteEnMateria(Materia materia, Docente docente)
        {
            using (Contexto contexto = new Contexto())
            {
                materia = contexto.Materias.Find(materia.Codigo);
                docente = contexto.Docentes.Find(docente.Id);
                contexto.Materias.Attach(materia);
                contexto.Docentes.Attach(docente);
                materia.Docentes.Remove(docente);
                docente.MateriasQueDicta.Remove(materia);

                contexto.SaveChanges();
            }
        }

        public void EliminarParticipanteEnActividad(Actividad unaActividad, Alumno unAlumno)
        {
            using (Contexto contexto = new Contexto())
            {
                var consultaActividad = contexto.Actividades.Include("Participantes").ToList();
                Actividad miActividad = consultaActividad.Where(actividad => actividad.Id.Equals(unaActividad.Id)).FirstOrDefault();
                miActividad.Participantes.Remove(unAlumno);
                contexto.Actividades.Attach(miActividad);

                var consultaAlumno = contexto.Alumnos.Include("ActividadesInscripto").ToList();
                Alumno miAlumno = consultaAlumno.Where(alumno => alumno.Id.Equals(unAlumno.Id)).FirstOrDefault();
                miAlumno.ActividadesInscripto.Remove(unaActividad);
                contexto.Alumnos.Attach(miAlumno);

                contexto.SaveChanges();
            }
        }

        public void EliminarTodosParticipantesDeActividad(Actividad unaActividad)
        {
            using (Contexto contexto = new Contexto())
            {
                var consultaActividad = contexto.Actividades.Include("Participantes").ToList();
                Actividad miActividad = consultaActividad.Where(actividad => actividad.Id.Equals(unaActividad.Id)).FirstOrDefault();
                // Elimino actividad dentro de los alumnos que participan de ella
                foreach (Alumno a in miActividad.Participantes)
                {
                    EliminarParticipanteEnActividad(unaActividad, a);
                }

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


        public Alumno ObtenerAlumnoPorID(int id)
        {
            using (Contexto contexto = new Contexto())
            {
                Alumno alumno = contexto.Alumnos.Find(id);
                contexto.Alumnos.Attach(alumno);
                return alumno;
            }
        }
        public void AgregarActividad(Actividad actividad)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Actividades.Add(actividad);
                contexto.SaveChanges();
            }
        }

        public Docente ObtenerDocentePorID(int id)
        {
            using (Contexto contexto = new Contexto())
            {
                Docente docente = contexto.Docentes.Find(id);
                contexto.Docentes.Attach(docente);
                return docente;
            }
        }

        public void ModificarActividad(Actividad aCambiar, Actividad nuevosDatos)
        {
            Actividad miActividad;
            using (Contexto contexto = new Contexto())
            {
                var query = from actividad in contexto.Actividades
                            where actividad.Id == aCambiar.Id
                            select actividad;

                miActividad = query.FirstOrDefault();

                contexto.Actividades.Attach(miActividad);
                miActividad.Nombre = nuevosDatos.Nombre;
                miActividad.Fecha = nuevosDatos.Fecha;
                miActividad.Costo = nuevosDatos.Costo;
                contexto.SaveChanges();
            }
        }

        public Actividad ObtenerActividadPorId(int id)
        {
            Actividad retorno;
            using (Contexto contexto = new Contexto())
            {
                var query = contexto.Actividades.Include("Participantes").ToList();
                retorno = query.Where(actividad => actividad.Id.Equals(id)).First();
            }
            return retorno;
        }
    }
}
