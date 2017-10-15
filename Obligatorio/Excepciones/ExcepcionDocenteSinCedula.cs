using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionDocenteSinCedula : Exception
    {
        public ExcepcionDocenteSinCedula() : base("ERROR: El docente no tiene una cedula asociada.") { }
    }
}
