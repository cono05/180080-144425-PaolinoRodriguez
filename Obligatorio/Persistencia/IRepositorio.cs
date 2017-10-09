using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Persistencia
{
    public interface IRepositorio
    {
        void AgregarMateria(Materia materia);
        void EliminarMateria(Materia materia);
        void AgregarAlumno(Alumno alumno);
        void EliminarAlumno(Alumno alumno);
        void AgregarDocente(Docente docente);
        void EliminarDocente(Docente docente);
        ICollection<Materia> ObtenerMaterias();
        
    }
}
