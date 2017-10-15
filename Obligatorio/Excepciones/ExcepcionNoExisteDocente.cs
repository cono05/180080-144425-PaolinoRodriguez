using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNoExisteDocente : Exception
    {
        public ExcepcionNoExisteDocente() : base("ERROR: No existe docente con esa cedula.") { }

    }
}
