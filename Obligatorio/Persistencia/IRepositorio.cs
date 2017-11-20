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
        void AgregarCamioneta(Camioneta camioneta);
        void EliminarCamioneta(Camioneta camioneta);
        void AgregarAlumnoEnMateria(Materia materia, Alumno alumno);
        void AgregarDocenteEnMateria(Materia materia, Docente docente);
        void EliminarDocenteEnMateria(Materia materia, Docente docente);
        void ModificarAlumno(Alumno aCambiar, Alumno nuevosDatos);
        void ModificarDocente(Docente aCambiar, Docente nuevosDatos);
        void ModificarMateria(Materia aCambiar, String nuevoNombre);

        ICollection<Materia> ObtenerMaterias();
        ICollection<Alumno> ObtenerAlumnos();
        ICollection<Docente> ObtenerDocentes();
        ICollection<Camioneta> ObtenerCamionetas();
        ICollection<Alumno> ObtenerAlumnosDeLaMateria(Materia materia);
        ICollection<Docente> ObtenerDocentesDeLaMateria(Materia materia);
        

    }
}
