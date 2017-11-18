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

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

    }
}