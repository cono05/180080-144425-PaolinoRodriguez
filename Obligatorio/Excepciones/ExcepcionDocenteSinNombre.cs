using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionDocenteSinNombre : Exception
    {
        public ExcepcionDocenteSinNombre() : base("ERROR: El docente no tiene un nombre asociado.") { }
    }
}
