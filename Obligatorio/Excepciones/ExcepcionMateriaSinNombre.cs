using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionMateriaSinNombre:Exception
    {
        public ExcepcionMateriaSinNombre() : base("ERROR: La materia no tiene un nombre asignado.")
        {
        }
    }
}
