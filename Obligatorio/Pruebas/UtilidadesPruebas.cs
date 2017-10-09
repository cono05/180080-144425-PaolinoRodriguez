using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Pruebas
{
    class UtilidadesPruebas
    {
        public static Materia CrearMateriaDePueba(string nombre)
        {
            Materia materia = Materia.CrearMateria();
            materia.Nombre = nombre;
            return materia;
        }


    }
}
