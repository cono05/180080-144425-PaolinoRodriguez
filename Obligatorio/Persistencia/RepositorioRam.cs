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
    }
}