using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionMateriasTest
    {
        [TestMethod]
        public void AgregarMateriaTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño");
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = new ModuloGestionMaterias(repositorio);
            modulo.Alta(materia);
            Assert.IsTrue(repositorio.Materias.Count == 1);
        }
    }
}
