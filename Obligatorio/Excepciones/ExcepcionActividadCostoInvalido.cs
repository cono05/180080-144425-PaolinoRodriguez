using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionActividadCostoInvalido : Exception
    {
        public ExcepcionActividadCostoInvalido() : base("ERROR: La actividad no tiene un costo asociado.") { }
    }
}