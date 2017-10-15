using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;

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
            Assert.IsTrue(modulo.ExisteDocenteConMismaCedula(docente1));
        }

        [TestMethod]
        public void ExisteDocenteConMismaCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-2");
            modulo.Alta(docente1);
            Assert.IsFalse(modulo.ExisteDocenteConMismaCedula(docente2));
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
            Assert.IsTrue(modulo.EsFormatoCedulaDocenteCorrecto(docente));
        }

        [TestMethod]
        public void EsFormatoCedulaDocenteCorrectoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(ref repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234-67-8");
            Assert.IsFalse(modulo.EsFormatoCedulaDocenteCorrecto(docente));
        }
    }
}
