using System.Collections.Generic;

namespace Dominio
{
    public class Alumno : Persona
    {
        public int NumeroDeEstudiante { get; set; }
        public string Cedula { get; set; }
        public ICollection<Materia> MateriasInscripto { get; set; }

        public Alumno()
        {
            this.Cedula = string.Empty;
            this.MateriasInscripto = new List<Materia>();
        }
        public static Alumno CrearAlumno()
        {
            Alumno alumno = new Alumno();
            return alumno;
        }
    }
}