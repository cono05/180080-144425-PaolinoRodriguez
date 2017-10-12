using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionAlumnoSinCedula : Exception
    {
        public ExcepcionAlumnoSinCedula() : base("ERROR: El alumno no tiene una cedula asociada.") { }
    }
}
