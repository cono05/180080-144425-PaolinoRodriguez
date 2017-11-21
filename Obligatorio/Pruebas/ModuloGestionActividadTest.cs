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
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            moduloActividad.Nombre = "moduloActividad";
            Assert.AreEqual("moduloActividad", moduloActividad.Nombre);
        }

        [TestMethod]
        public void GetDescripcionModuloGestionActividadTest()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            moduloActividad.Descripcion = "moduloActividadDescripcion";
            Assert.AreEqual("moduloActividadDescripcion", moduloActividad.Descripcion);
        }

        [TestMethod]
        public void AgregarActividadTest()
        {
            UtilidadesPruebas.VaciarTablas();
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
            UtilidadesPruebas.VaciarTablas();
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
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            DateTime fecha = new DateTime(2017, 12, 24);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadPruebaObtenerAct", fecha, 100);
            modulo.Alta(actividad);
            Assert.IsTrue(modulo.ObtenerActividades().Count > 0);
        }

        [TestMethod]
        public void ModificarActividadTest()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividadOriginal     = UtilidadesPruebas.CrearActividadDePrueba("ActividadPruebaOriginal", new DateTime(2017, 12, 24), 100);
            Actividad actividadNuevosDatos  = UtilidadesPruebas.CrearActividadDePrueba("ActividadPruebaNuevosDatos", new DateTime(2018, 02, 20), 200);
            modulo.Alta(actividadOriginal);
            string nombreOriginal = actividadOriginal.Nombre;
            DateTime fechaOriginal = actividadOriginal.Fecha;
            modulo.ModificarActividad(ref actividadOriginal, actividadNuevosDatos);

            foreach (Actividad act in modulo.ObtenerActividades())
            {
                if(act.Id == actividadOriginal.Id)
                {
                    string nombreActualizado = act.Nombre;
                    DateTime fechaActualizado = act.Fecha;
                    Assert.IsTrue(!(nombreOriginal.Equals(nombreActualizado)) && (fechaOriginal.CompareTo(fechaActualizado) != 0));
                }
            }  
        }

        [TestMethod]
        public void AgregarParticipanteEnActividadTest()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloAct = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlu = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadAgregarParticipante", new DateTime(2018, 1, 1), 2000);
            Alumno alumno       = UtilidadesPruebas.CrearAlumnoDePrueba("Carlitos", "Prueba", "1298637-8", "prueba@prueb.com", 78);
            moduloAct.Alta(actividad);
            moduloAlu.Alta(alumno);
            moduloAct.AgregarParticipanteEnActividad(actividad, alumno);
            foreach (Actividad act in moduloAct.ObtenerActividades())
            {
                if (act.Id == actividad.Id)
                {
                    Assert.IsTrue(actividad.Participantes.Count > 0);
                }
            }
        }
    }
}
