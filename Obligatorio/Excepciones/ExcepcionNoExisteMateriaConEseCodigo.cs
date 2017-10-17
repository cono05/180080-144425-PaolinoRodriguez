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
    }
}