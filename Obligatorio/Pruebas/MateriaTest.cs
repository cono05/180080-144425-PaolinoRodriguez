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
            Materia materia = new Materia();
            Assert.IsTrue(string.IsNullOrEmpty(materia.Nombre));
        }

        [TestMethod]
        public void CrearMateriaVaciaSinAlumnosTest()
        {
            Materia materia = new Materia();
            Assert.IsTrue(materia.Alumnos.Count == 0);
        }

        //[TestMethod]
        //public void CrearMateriaVaciaSinDocentesTest()
        //{
        //    Materia materia = new Materia();
        //    Assert.IsTrue(materia.Docentes.Count == 0);
        //}
    }
}
