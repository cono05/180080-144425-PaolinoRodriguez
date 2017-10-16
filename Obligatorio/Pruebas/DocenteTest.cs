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

        [TestMethod]
        public void ToStringTest()
        {
            Docente docente = Docente.CrearDocente();
            docente.Nombre = "Bruno";
            docente.Apellido = "Diaz";
            string esperado = "Bruno Diaz";
            Assert.AreEqual(esperado, docente.ToString());
        }
    }
}
