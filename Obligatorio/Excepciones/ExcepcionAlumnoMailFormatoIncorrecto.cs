using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionAlumnoMailFormatoIncorrecto : Exception
    {
    public ExcepcionAlumnoMailFormatoIncorrecto() : base("ERROR: Formato de mail no valido.") { }
    }
}
