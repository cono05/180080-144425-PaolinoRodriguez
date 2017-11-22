using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionCamionetaConsumoNoValido: Exception
    {
        public ExcepcionCamionetaConsumoNoValido():base("ERROR: El consumo debe ser un entero entre 5 y 20.")
        {
        }
    }
}
