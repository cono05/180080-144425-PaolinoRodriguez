using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ExcepcionExisteCamionetaConMismaChapa : Exception
    {
        public ExcepcionExisteCamionetaConMismaChapa(): base("ERROR: Ya existe camioneta con esa chapa.")
        {
        }       
    }
}