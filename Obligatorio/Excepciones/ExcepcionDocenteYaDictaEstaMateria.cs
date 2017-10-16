using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ExcepcionDocenteYaDictaEstaMateria : Exception
    {
        public ExcepcionDocenteYaDictaEstaMateria():base("El docente ya dicta esta materia actualmente.")
        {
        }

        public ExcepcionDocenteYaDictaEstaMateria(string message) : base(message)
        {
        }

        public ExcepcionDocenteYaDictaEstaMateria(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExcepcionDocenteYaDictaEstaMateria(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}