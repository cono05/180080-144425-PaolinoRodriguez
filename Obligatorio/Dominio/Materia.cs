using System.Collections.Generic;

namespace Dominio
{
    public class Materia
    {
        public ICollection<Alumno> Alumnos { get; set; }
        public ICollection<Docente> Docentes { get; set; }
        public string Nombre { get; set; }
        

        public Materia()
        {
            this.Nombre = string.Empty;
            this.Alumnos = new List<Alumno>();
            this.Docentes = new List<Docente>();
        }
    }
}