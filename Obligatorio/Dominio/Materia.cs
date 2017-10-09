using System.Collections.Generic;

namespace Dominio
{
    public class Materia
    {
        public ICollection<Alumno> Alumnos { get; set; }
        public ICollection<Docente> Docentes { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        

        public Materia()
        {
            this.Nombre = string.Empty;
            this.Codigo = string.Empty;
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
            if (obj != null && this.GetType() == obj.GetType())
            {
                Materia materia = (Materia)obj;
                equals = materia.Nombre.Equals(Nombre);
            }
            return equals;
        }
    }
}