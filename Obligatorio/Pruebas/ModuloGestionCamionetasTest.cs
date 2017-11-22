using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using Logica;
using Dominio;
using Excepciones;
namespace Pruebas
{
    [TestClass]
    public class ModuloGestionCamionetasTest
    {
        [TestMethod]
        public void GetNombreModuloGestionCamionetaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(repositorio);
            moduloCamionetas.Nombre = "moduloCamionetas";
            Assert.AreEqual("moduloCamionetas", moduloCamionetas.Nombre);
        }

        [TestMethod]
        public void GetDescripcionModuloGestionCamionetasTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            moduloCamionetas.Descripcion = "moduloDescripcion";
            Assert.AreEqual("moduloDescripcion", moduloCamionetas.Descripcion);
        }

        [TestMethod]
        public void AgregarCamionetaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20, 10);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ObtenerCamionetas().Contains(camioneta));
        }

        [TestMethod]
        public void EliminarCamionetaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20, 10);
            moduloCamionetas.Baja(camioneta);
            Assert.IsFalse(moduloCamionetas.ObtenerCamionetas().Contains(camioneta));
        }

        [TestMethod]
        public void ObtenerCamionetasTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20, 10);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ObtenerCamionetas().Count == 1 );
        }

        [TestMethod]
        public void ExisteCamionetaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20, 10);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ExisteCamioneta(camioneta));
        }

        [TestMethod]
        public void ExisteCamionetaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1212", 20, 10);
            Assert.IsFalse(moduloCamionetas.ExisteCamioneta(camioneta));
        }

        [TestMethod]
        public void EsCamionetaSinChapaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "", 20, 10);
            Assert.IsTrue(moduloCamionetas.EsCamionetaSinChapa(camioneta));
        }

        [TestMethod]
        public void EsCamionetaSinChapaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 20, 10);
            Assert.IsFalse(moduloCamionetas.EsCamionetaSinChapa(camioneta));
        }

        [TestMethod]
        public void EsCamionetaSinMarcaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("", "AAA1515", 20, 10);
            Assert.IsTrue(moduloCamionetas.EsCamionetaSinMarca(camioneta));
        }

        [TestMethod]
        public void ValidarAltaCamionetaOkTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 20, 10);
            moduloCamionetas.ValidarAlta(camioneta);
            moduloCamionetas.Alta(camioneta);
            Assert.IsTrue(moduloCamionetas.ExisteCamioneta(camioneta));
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionCamionetaSinMarca))]
        public void ValidarAltaCamionetaErrorMarcaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("", "AAA1515", 20, 10);
            moduloCamionetas.ValidarAlta(camioneta);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteCamionetaConMismaChapa))]
        public void ValidarAltaCamionetaErrorChapaRepetidaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 20, 10);
            moduloCamionetas.ValidarAlta(camioneta);
            moduloCamionetas.Alta(camioneta);
            moduloCamionetas.ValidarAlta(camioneta);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionCamionetaSinChapa))]
        public void ValidarAltaCamionetaErrorSinChapaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "", 20, 10);
            moduloCamionetas.ValidarAlta(camioneta);
        }

        [TestMethod]
        public void TieneCapacidadNoValidaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 9999, 10);
            Assert.IsTrue(moduloCamionetas.TieneCapacidadNoValida(camioneta));
        }

        [TestMethod]
        public void TieneCapacidadNoValidaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("", "AAA1515", 20, 10);
            Assert.IsFalse(moduloCamionetas.TieneCapacidadNoValida(camioneta));
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionCapacidadNoValida))]
        public void CapacidadNoValidaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 9999, 10);
            moduloCamionetas.TieneCapacidadNoValida(camioneta);
            moduloCamionetas.ValidarAlta(camioneta);
        }

        [TestMethod]
        public void ToStringTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba( repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 20, 10);
            Assert.AreEqual("Ford (AAA1515)", camioneta.ToString());
        }
    }
}
