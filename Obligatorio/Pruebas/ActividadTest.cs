using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;

namespace Pruebas
{
    [TestClass]
    public class ActividadTest
    {
        [TestMethod]
        public void CrearActividadVacioTest()
        {
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("", DateTime.Now, 0);
            Assert.IsTrue(string.IsNullOrEmpty(actividad.Nombre));

        }
    }
}
