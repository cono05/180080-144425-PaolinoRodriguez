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

        public RepositorioRam()
        {
            Materias = new List<Materia>();
            Alumnos = new List<Alumno>();
            Docentes = new List<Docente>();
            Camionetas = new List<Camioneta>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            this.Alumnos.Add(alumno);
        }

        public void AgregarDocente(Docente docente)
        {
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

        public void AgregarAlumnoEnMateria(Materia materia, Alumno alumno)
        {
            materia.Alumnos.Add(alumno);
            alumno.MateriasInscripto.Add(materia);
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
    }
}