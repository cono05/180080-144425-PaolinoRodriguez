using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionDocenteTest
    {

        [TestMethod]
        public void AgregarDocenteTest()
        {
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionDocente modulo = new ModuloGestionDocente(repositorio);
            modulo.Alta(docente);
            Assert.IsTrue(repositorio.Docentes.Count == 1);
        }

        [TestMethod]
        public void ExisteDocenteConMismaCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-2");
            modulo.Alta(docente1);
            Assert.IsTrue(modulo.ExisteDocenteConMismaCedula(docente1.Cedula));
        }

        [TestMethod]
        public void ExisteDocenteConMismaCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-2");
            modulo.Alta(docente1);
            Assert.IsFalse(modulo.ExisteDocenteConMismaCedula(docente2.Cedula));
        }

        [TestMethod]
        public void EsDocenteSinNombreTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("", "Apellido", "0000000-1");
            Assert.IsTrue(modulo.EsDocenteSinNombre(docente));
        }

        [TestMethod]
        public void EsDocenteSinNombreFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinNombre(docente));
        }

        [TestMethod]
        public void EsDocenteSinApellidoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "", "0000000-1");
            Assert.IsTrue(modulo.EsDocenteSinApellido(docente));
        }

        [TestMethod]
        public void EsDocenteSinApellidoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinApellido(docente));
        }

        [TestMethod]
        public void EsDocenteSinCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "");
            Assert.IsTrue(modulo.EsDocenteSinCedula(docente));
        }

        [TestMethod]
        public void EsDocenteSinCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinCedula(docente));
        }

        [TestMethod]
        public void EsFormatoCedulaDocenteCorrectoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Assert.IsTrue(modulo.EsFormatoCedulaDocenteCorrecto(docente.Cedula));
        }

        [TestMethod]
        public void EsFormatoCedulaDocenteCorrectoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234-67-8");
            Assert.IsFalse(modulo.EsFormatoCedulaDocenteCorrecto(docente.Cedula));
        }

        #region Validaciones
        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinNombre))]
        public void ValidarDocenteSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("", "Apellido", "1234567-8");
            modulo.ValidarDocente(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinApellido))]
        public void ValidarDocenteSinApellidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "", "1234567-8");
            modulo.ValidarDocente(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinCedula))]
        public void ValidarDocenteSinCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "");
            modulo.ValidarDocente(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionFormatoCedulaIncorrecto))]
        public void ValidarDocenteFormatoCedulaIncorrectoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "123-4");
            modulo.ValidarDocente(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteDocenteConMismaCedula))]
        public void ValidarDocenteConCedulaExistenteErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre2", "Apellido2", "1234567-8");
            modulo.Alta(docente1);
            modulo.ValidarDocente(docente2);
        }

        #endregion
    }
}
