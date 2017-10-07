using System.Collections.Generic;

namespace Dominio
{
    public class Docente : Persona
    {
        public ICollection<Materia> MateriasQueDicta { get; set; }
        public Docente()
        {
            this.MateriasQueDicta = new List<Materia>();
        }

        //public static Docente CrearDocente()
        //{
        //    Docente docente = new Docente();
        //    return docente;
        //}

       
    }
}