using System.Collections.Generic;

namespace Dominio
{
    public class Docente: Persona
    {
        public ICollection<Materia> MateriasQueDicta { get; set; }
        public Docente()
        {
        }

       
    }
}