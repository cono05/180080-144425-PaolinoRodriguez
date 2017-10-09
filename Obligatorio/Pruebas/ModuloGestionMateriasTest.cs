﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

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

        [TestMethod]
        public void ExisteMateriaConMismoNombreTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño");
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño");
            modulo.Alta(materia1);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia1));
        }

        [TestMethod]
        public void ExisteMateriaConMismoNombreFalseTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1");
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2");
            modulo.Alta(materia1);
            Assert.IsFalse(modulo.ExisteMateriaConMismoNombre(materia2));
        }

        [TestMethod]
        public void ValidarMateriaOKTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1");
            modulo.ValidarMateria(materia);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia));
        }
        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteMateriaConMismoNombre))]
        public void ValidarMateriaErrorNombreRepetidoTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1");
            modulo.ValidarMateria(materia);
            modulo.Alta(materia);
            modulo.ValidarMateria(materia);
        }

        [TestMethod]
        public void EsMateriaSinNombreTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1");
            Assert.IsFalse(modulo.EsMateriaSinNombre(materia));
        }

        [TestMethod]
        public void EsMateriaSinNombreTrueTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("");
            Assert.IsTrue(modulo.EsMateriaSinNombre(materia));
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionMateriaSinNombre))]
        public void ValidarMateriaSinNombreErrorTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("");
            modulo.ValidarMateria(materia);
        }
        
    }
}
