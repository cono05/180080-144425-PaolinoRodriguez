using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionActividadSinNombre : Exception
    {
        public ExcepcionActividadSinNombre() : base("ERROR: La actividad no tiene un nombre asociado.") { }
    }

}