using System.Collections.Generic;

namespace Dominio
{
    public class Docente : Persona
    {

        public virtual ICollection<Materia> MateriasQueDicta { get; set; }
        private Docente()
        {   
            this.MateriasQueDicta = new List<Materia>();
        }

        public static Docente CrearDocente()
        {
            Docente docente = new Docente();
            return docente;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && this.GetType() == obj.GetType())
            {
                Docente docente = (Docente)obj;
                equals = docente.Cedula.Equals(Cedula);
            }
            return equals;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

    }
}