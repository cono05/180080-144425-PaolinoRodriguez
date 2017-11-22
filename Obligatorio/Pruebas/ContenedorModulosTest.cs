using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using Persistencia;

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

        [TestMethod]
        public void AgregarModuloTest()
        {
            ContenedorModulos contenedor = new ContenedorModulos();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            contenedor.AgregarModulo(modulo);
            Assert.IsTrue(contenedor.Modulos.Count == 1);
        }

        [TestMethod]
        public void ObtenerModulosTest()
        {
            ContenedorModulos contenedor = new ContenedorModulos();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            contenedor.AgregarModulo(modulo);
            Assert.IsTrue(contenedor.ObtenerModulos().Count == 1);
        }


    }
    
}
