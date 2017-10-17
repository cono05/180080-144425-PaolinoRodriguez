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

        public ExcepcionExisteCamionetaConMismaChapa(string message) : base(message)
        {
        }

        public ExcepcionExisteCamionetaConMismaChapa(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExcepcionExisteCamionetaConMismaChapa(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}