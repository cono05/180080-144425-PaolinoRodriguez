using System.Collections.Generic;

namespace Dominio
{
    public class Alumno : Persona
    {
        public int NumeroDeEstudiante { get; set; }
        public string Mail { get; set; }
        public virtual ICollection<Materia> MateriasInscripto { get; set; }

        private static int numero = 1111;
        private Alumno()
        {
            MateriasInscripto = new List<Materia>();
            NumeroDeEstudiante = ++numero;
        }
        public static Alumno CrearAlumno()
        {
            Alumno alumno = new Alumno();
            return alumno;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && this.GetType() == obj.GetType())
            {
                Alumno alumno = (Alumno)obj;
                equals = alumno.NumeroDeEstudiante.Equals(NumeroDeEstudiante);
            }
            return equals;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido + " (" + NumeroDeEstudiante + ")";
        }
    }
}