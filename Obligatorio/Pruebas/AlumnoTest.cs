using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;

namespace Pruebas
{
    [TestClass]
    public class AlumnoTest
    {
        [TestMethod]
        public void CrearAlumnoVacioTest()
        {
            Alumno alumno = new Alumno();
            Assert.IsTrue(string.IsNullOrEmpty(alumno.Apellido));
            
        }


    }
}
