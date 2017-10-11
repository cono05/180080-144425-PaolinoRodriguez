using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public class RepositorioRam : IRepositorio
    {
        public ICollection<Materia> Materias { get; set; }
        public ICollection<Alumno> Alumnos { get; set; }

        public RepositorioRam()
        {
            this.Materias = new List<Materia>();
            this.Alumnos = new List<Alumno>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            this.Alumnos.Add(alumno);
        }

        public void AgregarDocente(Docente docente)
        {
            throw new NotImplementedException();
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
            return this.Materias;
        }

        public ICollection<Alumno> ObtenerAlumnos()
        {
            return Alumnos;
        }
    }
}