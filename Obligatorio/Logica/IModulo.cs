using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IModulo
    {
        void Alta(Object obj);
        void Baja(Object obj);
        string ObtenerNombre();
    }
}
