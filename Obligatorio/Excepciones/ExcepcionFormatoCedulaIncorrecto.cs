using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionFormatoCedulaIncorrecto : Exception
    {
        public ExcepcionFormatoCedulaIncorrecto() : base("ERROR: El formato de la cedula es incorrecto.") { }
    }
}
