using System.Collections.Generic;

namespace Dominio
{
    public class Docente : Persona
    {

        public ICollection<Materia> MateriasQueDicta { get; set; }
        private Docente()
        {
            Id = Id++;
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