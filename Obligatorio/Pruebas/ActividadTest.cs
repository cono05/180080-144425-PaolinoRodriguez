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

        [TestMethod]
        public void EqualsOkTest()
        {
            Actividad actividad1 = UtilidadesPruebas.CrearActividadDePrueba("Evento1", DateTime.Now, 0);
            Actividad actividad2 = UtilidadesPruebas.CrearActividadDePrueba("Evento1", DateTime.Now, 0);
            actividad1.Id = actividad2.Id;
            Assert.IsTrue(actividad1.Equals(actividad2));
        }

        [TestMethod]
        public void ToStringTest()
        {
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Evento1", DateTime.Now, 0);
            string esperado = "Actividad: Evento1" + " Fecha: " + DateTime.Now;
            Assert.AreEqual(esperado, actividad.ToString());
        }
    }
}
