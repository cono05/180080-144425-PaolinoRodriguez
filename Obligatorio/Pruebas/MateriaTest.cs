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
        public void EqualsOkTest()
        {
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1" , 10);
            Assert.IsTrue(materia2.Equals(materia2));
        }

        [TestMethod]
        public void EqualsFalseTest()
        {
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1" , 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2" , 16);
            Assert.IsFalse(materia1.Equals(materia2));
        }

        [TestMethod]
        public void AsignacionDeCodigoAutomaticoTest()
        {
            Materia materia3 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Materia materia4 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Assert.IsTrue(materia4.Codigo - materia3.Codigo == 1);
        }

        [TestMethod]
        public void ToStringTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño 1", 11);
            int codigoMateria = materia.Codigo;
            string esperado = "Diseño 1" + "(" + materia.Codigo + ")";
            Assert.AreEqual(esperado, materia.ToString());
        }
    }
}
