﻿using System;
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
    }
}
