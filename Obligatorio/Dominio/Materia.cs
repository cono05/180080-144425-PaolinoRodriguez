using System.Collections.Generic;

namespace Dominio
{
    public class Materia
    {
        public virtual ICollection<Alumno> Alumnos { get; set; }
        public virtual ICollection<Docente> Docentes { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        private static int numero = 1000;
        

        public Materia()
        {
            this.Nombre = string.Empty;
            this.Codigo = ++numero;
            this.Alumnos = new List<Alumno>();
            this.Docentes = new List<Docente>();
        }

        public static Materia CrearMateria()
        {
            Materia materia = new Materia();
            return materia;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null/* && this.GetType() == obj.GetType()*/)
            {
                Materia materia = (Materia)obj;
                equals = materia.Codigo == Codigo;
            }
            return equals;
        }

        public override string ToString()
        {
            return Nombre + "(" + Codigo + ")";
        }
    }
}