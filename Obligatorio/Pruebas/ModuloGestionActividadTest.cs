using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionActividadTest
    {
        [TestMethod]
        public void GetNombreModuloGestionActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            moduloActividad.Nombre = "moduloActividad";
            Assert.AreEqual("moduloActividad", moduloActividad.Nombre);
        }

        [TestMethod]
        public void GetDescripcionModuloGestionActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            moduloActividad.Descripcion = "moduloActividadDescripcion";
            Assert.AreEqual("moduloActividadDescripcion", moduloActividad.Descripcion);
        }

        [TestMethod]
        public void AgregarActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            DateTime fecha = new DateTime(2017, 12, 24);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Actividad1", fecha, 100);
            modulo.Alta(actividad);
            Assert.IsTrue(modulo.ObtenerActividades().Count > 0);
        }

        [TestMethod]
        public void EliminarActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            DateTime fecha = new DateTime(2017, 12, 24);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Actividad1", fecha, 100);
            modulo.Alta(actividad);
            int antesEliminar = modulo.ObtenerActividades().Count;
            modulo.Baja(actividad);
            int despuesEliminar = modulo.ObtenerActividades().Count;
            Assert.IsTrue(antesEliminar == despuesEliminar + 1);
        }

        [TestMethod]
        public void ObtenerActividadesTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            DateTime fecha = new DateTime(2017, 12, 24);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadPruebaObtenerAct", fecha, 100);
            modulo.Alta(actividad);
            Assert.IsTrue(modulo.ObtenerActividades().Count > 0);
        }
    }
}
