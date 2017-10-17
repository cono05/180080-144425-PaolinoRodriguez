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

        public ExcepcionCamionetaSinMarca(string message) : base(message)
        {
        }

        public ExcepcionCamionetaSinMarca(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExcepcionCamionetaSinMarca(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}