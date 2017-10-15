using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNoExisteAlumno : Exception
    {
        public ExcepcionNoExisteAlumno() : base("ERROR: No existe alumno con esa cedula.") { }
    }
}
