using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ExcepcionNoExisteMateriaConEseCodigo : Exception
    {
        public ExcepcionNoExisteMateriaConEseCodigo():base("La materia no existe en el sistema.")
        {
        }

        public ExcepcionNoExisteMateriaConEseCodigo(string message) : base(message)
        {
        }

        public ExcepcionNoExisteMateriaConEseCodigo(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExcepcionNoExisteMateriaConEseCodigo(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}