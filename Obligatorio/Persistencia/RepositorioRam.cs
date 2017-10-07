using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public class RepositorioRam : IRepositorio
    {
        public ICollection<Materia> Materias { get; set; }

        public RepositorioRam()
        {
            this.Materias = new List<Materia>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public void AgregarDocente(Docente docente)
        {
            throw new NotImplementedException();
        }

        public void AgregarMateria(Materia materia)
        {
            this.Materias.Add((Materia)materia);
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
    }
}