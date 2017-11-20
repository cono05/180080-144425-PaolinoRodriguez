using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionActividadesTest
    {
        [TestMethod]
        public void GetNombreModuloGestionAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            moduloAlumno.Nombre = "moduloAlumno";
            Assert.AreEqual("moduloAlumno", moduloAlumno.Nombre);
        }
    }
}
