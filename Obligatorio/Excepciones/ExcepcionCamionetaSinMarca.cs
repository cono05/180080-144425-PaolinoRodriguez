using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ExcepcionCamionetaSinMarca : Exception
    {
        public ExcepcionCamionetaSinMarca():base("ERROR: No se ha especificado la marca de la camioneta.")
        {
        }       
    }
}