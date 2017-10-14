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
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-2");
            modulo.Alta(docente1);
            Assert.IsTrue(modulo.ExisteDocenteConMismaCedula(docente1));
        }

        [TestMethod]
        public void ExisteDocenteConMismaCedulaFalseTest()
        {
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-2");
            modulo.Alta(docente1);
            Assert.IsFalse(modulo.ExisteDocenteConMismaCedula(docente2));
        }

        [TestMethod]
        public void EsDocenteSinNombreTest()
        {
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("", "Apellido", "0000000-1");
            Assert.IsTrue(modulo.EsDocenteSinNombre(docente));
        }

        [TestMethod]
        public void EsDocenteSinNombreFalseTest()
        {
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinNombre(docente));
        }

        [TestMethod]
        public void EsDocenteSinApellidoTest()
        {
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "", "0000000-1");
            Assert.IsTrue(modulo.EsDocenteSinApellido(docente));
        }

        [TestMethod]
        public void EsDocenteSinApellidoFalseTest()
        {
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinApellido(docente));
        }

        [TestMethod]
        public void EsDocenteSinCedulaTest()
        {
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "");
            Assert.IsTrue(modulo.EsDocenteSinCedula(docente));
        }

        [TestMethod]
        public void EsDocenteSinCedulaFalseTest()
        {
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba();
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinCedula(docente));
        }

    }
}
