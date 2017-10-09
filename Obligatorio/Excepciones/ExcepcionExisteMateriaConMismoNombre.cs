using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionExisteMateriaConMismoNombre:Exception
    {
        public ExcepcionExisteMateriaConMismoNombre() : base("ERROR: Ya existe una materia con el mismo nombre.")
        {
        }
    }
}
