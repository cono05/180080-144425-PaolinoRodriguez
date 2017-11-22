using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Pruebas
{
    [TestClass]
    public class ContenedorModulosTest
    {
        [TestMethod]
        public void CrearContenedorModulosVacioTest()
        {
            ContenedorModulos contenedor = new ContenedorModulos();
            Assert.IsTrue(contenedor.Modulos.Count == 0);
        }
    }
}
