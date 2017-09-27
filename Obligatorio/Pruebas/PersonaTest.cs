using System;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PersonaTest
    {
        [TestMethod]
        public void CrearPersonaNombreVacioTest()
        {
            Persona persona = new AlumnoTest();
            Assert.IsTrue(string.IsNullOrEmpty(persona.Nombre));
        }

        [TestMethod]
        public void CrearPersonaApellidoVacioTest()
        {
            Persona persona = new AlumnoTest();
            Assert.IsTrue(string.IsNullOrEmpty(persona.Apellido));
        }
    }
}
