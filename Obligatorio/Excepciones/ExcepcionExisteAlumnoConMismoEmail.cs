using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionExisteAlumnoConMismoEmail : Exception
    {
        public ExcepcionExisteAlumnoConMismoEmail() : base("ERROR: Ya existe otro alumno con mismo email.") { }
    }
}
