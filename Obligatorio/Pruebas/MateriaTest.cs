using System;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class MateriaTest
    {
        [TestMethod]
        public void CrearMateriaVaciaTest()
        {
            Materia materia = Materia.CrearMateria();
            Assert.IsTrue(string.IsNullOrEmpty(materia.Nombre));
        }

        [TestMethod]
        public void CrearMateriaVaciaSinAlumnosTest()
        {
            Materia materia = Materia.CrearMateria();
            Assert.IsTrue(materia.Alumnos.Count == 0);
        }

        [TestMethod]
        public void CrearMateriaVaciaSinDocentesTest()
        {
            Materia materia = Materia.CrearMateria();
            Assert.IsTrue(materia.Docentes.Count == 0);
        }
        [TestMethod]
        public void EqualsTest()
        {
           Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1");
           Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2");
            Assert.IsTrue(materia1.Equals(materia2));
        }
    }
}
