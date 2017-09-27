using System;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class DocenteTest
    {
        [TestMethod]
        public void CrearDocenteVacioTest()
        {
            Docente docente = new Docente();
            Assert.IsTrue(docente.MateriasQueDicta.Count == 0);
        }
    }
}
