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

        public ExcepcionCamionetaSinChapa(string message) : base(message)
        {
        }

        public ExcepcionCamionetaSinChapa(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExcepcionCamionetaSinChapa(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}