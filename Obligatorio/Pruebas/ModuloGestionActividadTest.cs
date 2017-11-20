using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionActividadTest
    {
        [TestMethod]
        public void GetNombreModuloGestionActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            moduloActividad.Nombre = "moduloActividad";
            Assert.AreEqual("moduloActividad", moduloActividad.Nombre);
        }

        [TestMethod]
        public void GetDescripcionModuloGestionActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            moduloActividad.Descripcion = "moduloActividadDescripcion";
            Assert.AreEqual("moduloActividadDescripcion", moduloActividad.Descripcion);
        }
    }
}
