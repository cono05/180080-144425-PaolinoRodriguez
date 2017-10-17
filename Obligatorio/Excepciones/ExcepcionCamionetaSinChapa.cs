using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ExcepcionCamionetaSinChapa : Exception
    {
        public ExcepcionCamionetaSinChapa():base("ERROR: La chapa de la camioneta es vacía.")
        {
        }        
    }
}