using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionDocenteSinApellido : Exception
    {
        public ExcepcionDocenteSinApellido() : base("ERROR: El docente no tiene un apellido asociado.") { }
    }
}
