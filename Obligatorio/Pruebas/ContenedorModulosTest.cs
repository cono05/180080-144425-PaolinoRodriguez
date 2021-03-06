﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;
using Persistencia;

namespace Pruebas
{
    [TestClass]
    public class ContenedorModulosTest
    {
        [TestMethod]
        public void CrearContenedorModulosVacioTest()
        {
            ContenedorModulos contenedor = ContenedorModulos.ObtenerInstancia();
            Assert.IsTrue(contenedor.Modulos.Count == 0);
        }

        [TestMethod]
        public void AgregarModuloTest()
        {
            ContenedorModulos contenedor = ContenedorModulos.ObtenerInstancia();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            contenedor.AgregarModulo(modulo);
            Assert.IsTrue(contenedor.Modulos.Count == 1);
        }

        
        [TestMethod]
        public void ObtenerModuloTest()
        {
            ContenedorModulos contenedor = ContenedorModulos.ObtenerInstancia();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            contenedor.AgregarModulo(modulo);
            IModulo obtenido = contenedor.ObtenerModulo("ModuloActividades");
            Assert.IsTrue(obtenido.ObtenerNombre().Equals("ModuloActividades"));
        }


    }
    
}
