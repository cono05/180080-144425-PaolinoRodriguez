using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionActividadFechaInvalida : Exception
    {
        public ExcepcionActividadFechaInvalida() : base("ERROR: La actividad no tiene una fecha asociada (Fecha > fecha actual).") { }
    }

}