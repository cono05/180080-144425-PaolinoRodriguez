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
    }
}