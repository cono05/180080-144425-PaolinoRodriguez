using System.Collections.Generic;

namespace Dominio
{
    public class Materia
    {
        public ICollection<Alumno> Alumnos { get; set; }
        public string Nombre { get; set; }

        public Materia()
        {
            this.Alumnos = new List<Alumno>();
        }
    }
}