using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
namespace Pruebas
{
    [TestClass]
    public class ModuloGestionMateriasTest
    {
        [TestMethod]
        public void AgregarMateriaTest()
        {
            Materia materia = Materia.CrearMateria();
            materia.Nombre = "Diseño";
            ModuloGestionMaterias modulo = new ModuloGestionMaterias(IRepositorio repositorio);
        }
    }
}
