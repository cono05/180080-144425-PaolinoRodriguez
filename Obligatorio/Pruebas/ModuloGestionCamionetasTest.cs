using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using Logica;
using Dominio;
namespace Pruebas
{
    [TestClass]
    public class ModuloGestionCamionetasTest
    {
        [TestMethod]
        public void GetNombreModuloGestionCamionetaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            moduloCamionetas.Nombre = "moduloCamionetas";
            Assert.AreEqual("moduloCamionetas", moduloCamionetas.Nombre);
        }

        [TestMethod]
        public void GetDescripcionModuloGestionCamionetasTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            moduloCamionetas.Descripcion = "moduloDescripcion";
            Assert.AreEqual("moduloDescripcion", moduloCamionetas.Descripcion);
        }

        [TestMethod]
        public void AgregarCamionetaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ObtenerCamionetas().Contains(camioneta));
        }

        [TestMethod]
        public void EliminarCamionetaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20);
            moduloCamionetas.Baja(camioneta);
            Assert.IsFalse(moduloCamionetas.ObtenerCamionetas().Contains(camioneta));
        }

        [TestMethod]
        public void ObtenerCamionetasTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ObtenerCamionetas().Count == 1 );
        }

        [TestMethod]
        public void ExisteCamionetaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ExisteCamioneta(camioneta));
        }

        [TestMethod]
        public void ExisteCamionetaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20);
            Assert.IsFalse(moduloCamionetas.ExisteCamioneta(camioneta));
        }

        [TestMethod]
        public void EsCamionetaSinChapaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "", 20);
            Assert.IsTrue(moduloCamionetas.EsCamionetaSinChapa(camioneta));
        }

        [TestMethod]
        public void EsCamionetaSinChapaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 20);
            Assert.IsFalse(moduloCamionetas.EsCamionetaSinChapa(camioneta));
        }

        [TestMethod]
        public void EsCamionetaSinMarcaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("", "AAA1515", 20);
            Assert.IsTrue(moduloCamionetas.EsCamionetaSinMarca(camioneta));
        }

        [TestMethod]
        public void ValidarAltaCamionetaOkTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 20);
            moduloCamionetas.ValidarAlta(camioneta);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ExisteCamioneta(camioneta));
        }

        [TestMethod]
        public void TieneCapacidadNoValidaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 0);
            Assert.IsTrue(moduloCamionetas.TieneCapacidadNoValida(camioneta));
        }

        [TestMethod]
        public void TieneCapacidadNoValidaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(ref repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 20);
            Assert.IsFalse(moduloCamionetas.TieneCapacidadNoValida(camioneta));
        }
        
    }
}
