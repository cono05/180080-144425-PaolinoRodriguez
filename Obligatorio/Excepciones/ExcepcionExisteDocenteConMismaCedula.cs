using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionExisteDocenteConMismaCedula : Exception
    {
        public ExcepcionExisteDocenteConMismaCedula() : base("ERROR: Ya existe otro docente con mismo numero de cedula.") { }
    }
}
