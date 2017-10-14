using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionAlumnoSinApellido : Exception
    {
        public ExcepcionAlumnoSinApellido() : base("ERROR: El alumno no tiene un apellido asociado.") { }
    }
}
