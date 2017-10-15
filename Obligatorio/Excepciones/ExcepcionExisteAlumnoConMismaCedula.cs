using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionExisteAlumnoConMismaCedula : Exception
    {
        public ExcepcionExisteAlumnoConMismaCedula() : base("ERROR: Ya existe otro alumno con mismo numero de cedula.") { }
    }
}
