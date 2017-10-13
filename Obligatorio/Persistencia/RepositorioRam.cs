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

        public RepositorioRam()
        {
            Materias = new List<Materia>();
            Alumnos = new List<Alumno>();
            Docentes = new List<Docente>();
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
    }
}