using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionAlumnoSinNombre : Exception
    {
        public ExcepcionAlumnoSinNombre() : base("ERROR: El alumno no tiene un nombre asociado.") { }
    }

}
