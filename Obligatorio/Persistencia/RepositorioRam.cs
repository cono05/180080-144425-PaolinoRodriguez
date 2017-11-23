using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public class RepositorioRam : IRepositorio
    {
        public ICollection<Materia> Materias { get; set; }
        public ICollection<Alumno> Alumnos { get; set; }
        public ICollection<Docente> Docentes { get; set; }
        public ICollection<Camioneta> Camionetas { get; set; }
        public ICollection<Actividad> Actividades { get; set; }
        
        private static int Id = 1;
        public RepositorioRam()
        {
            Materias = new List<Materia>();
            Alumnos = new List<Alumno>();
            Docentes = new List<Docente>();
            Camionetas = new List<Camioneta>();
            Actividades = new List<Actividad>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            alumno.Id = Id;
            Id++;
            this.Alumnos.Add(alumno);
        }

        

        public void AgregarDocente(Docente docente)
        {
            docente.Id = Id;
            Id++;
            this.Docentes.Add(docente);
        }

        public void AgregarMateria(Materia materia)
        {
            this.Materias.Add(materia);
        }

        public void AgregarCamioneta(Camioneta camioneta)
        {
            Camionetas.Add(camioneta);
        }

        public void AgregarActividad(Actividad actividad)
        {
            Actividades.Add(actividad);
        }

        public void EliminarAlumno(Alumno alumno)
        {
            this.Alumnos.Remove(alumno);
        }

        public void EliminarDocente(Docente docente)
        {
            this.Docentes.Remove(docente);
        }

        public void EliminarMateria(Materia materia)
        {
            Materias.Remove(materia);
        }

        public void EliminarCamioneta(Camioneta camioneta)
        {
            Camionetas.Remove(camioneta);
        }

        public void EliminarActividad(Actividad actividad)
        {
            Actividades.Remove(actividad);
        }

        public ICollection<Materia> ObtenerMaterias() {
            return Materias;
        }

        public ICollection<Alumno> ObtenerAlumnos()
        {
            return Alumnos;
        }

        public ICollection<Docente> ObtenerDocentes()
        {
            return Docentes;
        }

        public ICollection<Camioneta> ObtenerCamionetas()
        {
            return Camionetas;
        }
        public ICollection<Actividad> ObtenerActividades()
        {
            return Actividades;
        }

        public void AgregarAlumnoEnMateria(Materia materia, Alumno alumno)
        {
            materia.Alumnos.Add(alumno);
            alumno.MateriasInscripto.Add(materia);
        }

        public void AgregarParticipanteEnActividad(Actividad actividad, Alumno alumno)
        {
            actividad.Participantes.Add(alumno);
            alumno.ActividadesInscripto.Add(actividad);            
        }

        public void EliminarAlumnoDeMateria(Materia materia, Alumno alumno)
        {
            materia.Alumnos.Remove(alumno);
            alumno.MateriasInscripto.Remove(materia);
        }

        public void EliminarParticipanteEnActividad(Actividad actividad, Alumno alumno)
        {
            actividad.Participantes.Remove(alumno);
            alumno.ActividadesInscripto.Remove(actividad);
        }

        public ICollection<Alumno> ObtenerAlumnosDeLaMateria(Materia materia)
        {
            return materia.Alumnos;
        }

        public ICollection<Docente> ObtenerDocentesDeLaMateria(Materia materia)
        {
            return materia.Docentes;
        }

        public void AgregarDocenteEnMateria(Materia materia, Docente docente)
        {
            docente.MateriasQueDicta.Add(materia);
            materia.Docentes.Add(docente);
        }

        public void EliminarDocenteEnMateria(Materia materia, Docente docente)
        {
            materia.Docentes.Remove(docente);
            docente.MateriasQueDicta.Remove(materia);
        }
        public void ModificarAlumno(Alumno aCambiar, Alumno nuevosDatos)
        {
            aCambiar.Nombre     = nuevosDatos.Nombre;
            aCambiar.Apellido   = nuevosDatos.Apellido;
            aCambiar.Cedula     = nuevosDatos.Cedula;
            aCambiar.Mail       = nuevosDatos.Mail;
        }

        public void ModificarDocente(Docente aCambiar, Docente nuevosDatos)
        {
            aCambiar.Nombre = nuevosDatos.Nombre;
            aCambiar.Apellido = nuevosDatos.Apellido;
            aCambiar.Cedula = nuevosDatos.Cedula;
        }

        public void ModificarMateria(Materia aCambiar, String nuevoNombre)
        {
            aCambiar.Nombre = nuevoNombre;
        }

        public void ModificarActividad(Actividad aCambiar, Actividad nuevosDatos)
        {
            aCambiar.Nombre = nuevosDatos.Nombre;
            aCambiar.Fecha = nuevosDatos.Fecha;
            aCambiar.Costo = nuevosDatos.Costo;
        }

        public Actividad ObtenerActividadPorId(int id)
        {
            foreach(Actividad act in this.Actividades)
            {
                if(act.Id == id)
                    return act;
            }
            return null;
        }

        public Docente ObtenerDocentePorID(int id)
        {
            foreach (Docente docente in Docentes)
            {
                if (docente.Id == id)
                    return docente;
            }
            return null;
        }

        public Alumno ObtenerAlumnoPorID(int id)
        {
            foreach (Alumno alumno in Alumnos)
            {
                if (alumno.Id == id)
                    return alumno;
            }
            return null;
        }

        public Materia ObtenerMateriaPorCodigo(int codigo)
        {
            foreach (Materia materia in Materias)
            {
                if (materia.Codigo == codigo)
                    return materia;
            }
            return null;
        }

        public void EliminarTodosParticipantesDeActividad(Actividad unaActividad)
        {
            unaActividad.Participantes.Clear();
        }

        public void VaciarTablas()
        {
            Alumnos.Clear();
            Docentes.Clear();
            Materias.Clear();
            Camionetas.Clear();
            Actividades.Clear();
        }
    }
}