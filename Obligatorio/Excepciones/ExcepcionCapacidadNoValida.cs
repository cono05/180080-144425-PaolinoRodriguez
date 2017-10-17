using System;
using System.Runtime.Serialization;

namespace Excepciones
{
    [Serializable]
    public class ExcepcionCapacidadNoValida : Exception
    {
        public ExcepcionCapacidadNoValida() : base("ERROR: La capacidad debe ser un valor entre 1 y 40.") 
        {
        }

       
    }
}