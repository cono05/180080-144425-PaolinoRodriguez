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

        [TestInitialize]
        public void TestInitialize()
        {
            UtilidadesPruebas.VaciarTablas();
        }

        [TestMethod]
        public void AgregarActividadTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            DateTime fecha = new DateTime(2017, 12, 24);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Actividad1", fecha, 100);
            modulo.Alta(actividad);
            Assert.IsTrue(modulo.ObtenerActividades().Count == 1);
        }

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
        public void EliminarActividadTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            DateTime fecha = new DateTime(2017, 12, 24);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Actividad1", fecha, 100);
            modulo.Alta(actividad);
            modulo.Baja(actividad);
            Assert.IsTrue(modulo.ObtenerActividades().Count == 0);
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
        public void ObtenerActividadPorIdTest()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadPruebaObtenerAct", new DateTime(2027, 1, 12), 132);
            modulo.Alta(actividad);
            Actividad nuevaAct = modulo.ObtenerActividadPorId(actividad.Id);
            Assert.IsTrue(nuevaAct.Equals(actividad));
        }

        [TestMethod]
        public void ObtenerActividadPorIdNULLTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad obtenidaPorId = modulo.ObtenerActividadPorId(10);
            Assert.IsTrue(obtenidaPorId == null);
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

            string nombreActualizado = modulo.ObtenerActividadPorId(actividadOriginal.Id).Nombre;
            DateTime fechaActualizado = modulo.ObtenerActividadPorId(actividadOriginal.Id).Fecha;

            Assert.IsTrue(!(nombreOriginal.Equals(nombreActualizado)) && (fechaOriginal.CompareTo(fechaActualizado) != 0));
        }

        [TestMethod]
        public void AgregarParticipanteEnActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloAct = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlu = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadAgregarParticipante", new DateTime(2018, 1, 1), 2000);
            Alumno alumno       = UtilidadesPruebas.CrearAlumnoDePrueba("Carlitos", "Prueba", "1298637-8", "prueba@prueb.com", 78);
            moduloAct.Alta(actividad);
            moduloAlu.Alta(alumno);
            moduloAct.AgregarParticipanteEnActividad(actividad, alumno);

            Assert.IsTrue(moduloAct.ObtenerActividadPorId(actividad.Id).Participantes.Count > 0);
        }

        [TestMethod]
        public void EliminarParticipanteEnActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloAct = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlu = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadAgregarParticipante", new DateTime(2018, 1, 1), 2000);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Carlitos", "Prueba", "1298637-8", "prueba@prueb.com", 78);
            moduloAct.Alta(actividad);
            moduloAlu.Alta(alumno);
            moduloAct.AgregarParticipanteEnActividad(actividad, alumno);
            bool seAgrego = (moduloAct.ObtenerActividadPorId(actividad.Id).Participantes.Count > 0) ? true : false;
            moduloAct.EliminarParticipanteEnActividad(actividad, alumno);
            bool seElimino = (moduloAct.ObtenerActividadPorId(actividad.Id).Participantes.Count == 0) ? true : false;

            Assert.IsTrue(seAgrego && seElimino);
        }

        [TestMethod]
        public void EliminarParticipanteEnActividadTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionActividad moduloAct = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlu = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadAgregarParticipante", new DateTime(2018, 1, 1), 2000);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Carlitos", "Prueba", "1298637-8", "prueba@prueb.com", 78);
            moduloAct.Alta(actividad);
            moduloAlu.Alta(alumno);
            moduloAct.AgregarParticipanteEnActividad(actividad, alumno);
            moduloAct.EliminarParticipanteEnActividad(actividad, alumno);
            Assert.IsTrue(actividad.Participantes.Count == 0);
        }

        [TestMethod]
        public void EsActividadSinNombreTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("", new DateTime(2017, 1, 1), 10);
            Assert.IsTrue(modulo.EsActividadSinNombre(actividad));
        }

        [TestMethod]
        public void EsActividadSinFechaTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Nombre", new DateTime(1, 1, 1), 10);
            Assert.IsTrue(modulo.EsActividadFechaInvalida(actividad));
        }

        [TestMethod]
        public void EsActividadSinCostoTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Nombre", new DateTime(2017, 1, 1), 0);
            Assert.IsTrue(modulo.EsActividadCostoInvalido(actividad));
        }

        [TestMethod]
        public void EstaParticipanteInscriptoEnActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlumno = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Nombre", new DateTime(2018, 1, 1), 90);
            moduloActividad.Alta(actividad);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            moduloAlumno.Alta(alumno);
            moduloActividad.AgregarParticipanteEnActividad(actividad, alumno);

            Assert.IsTrue(moduloActividad.EstaParticipanteInscriptoEnActividad(alumno, actividad));

        }

        [TestMethod]
        public void EstaParticipanteInscriptoEnActividadFalseTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloActividad  = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlumno        = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("Nombre", new DateTime(2018, 1, 1), 90);
            moduloActividad.Alta(actividad);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);

            Assert.IsFalse(moduloActividad.EstaParticipanteInscriptoEnActividad(alumno, actividad));

        }

        [TestMethod]
        public void EliminarTodosParticipantesDeActividadTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad moduloAct = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlu    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);

            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadAgregarParticipante", new DateTime(2018, 1, 1), 2000);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Carlitos", "Prueba", "1298637-8", "pru@prueb.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Marcos", "Sentolla", "1223147-8", "prue@prueb.com", 2);
            Alumno alumno3 = UtilidadesPruebas.CrearAlumnoDePrueba("Loco", "Robles", "1209807-8", "prueba@prueb.com", 3);
            moduloAct.Alta(actividad);
            moduloAlu.Alta(alumno1);
            moduloAlu.Alta(alumno2);
            moduloAlu.Alta(alumno3);

            moduloAct.AgregarParticipanteEnActividad(actividad, alumno1);
            moduloAct.AgregarParticipanteEnActividad(actividad, alumno2);
            moduloAct.AgregarParticipanteEnActividad(actividad, alumno3);

            bool seAgregaron = (moduloAct.ObtenerActividadPorId(actividad.Id).Participantes.Count == 3) ? true : false;
            moduloAct.EliminarTodosParticipantesDeActividad(actividad);
            bool seEliminaron = (moduloAct.ObtenerActividadPorId(actividad.Id).Participantes.Count == 0) ? true : false;

            Assert.IsTrue(seAgregaron && seEliminaron);
        }

        #region Validaciones
        [TestMethod]
        [ExpectedException(typeof(ExcepcionActividadSinNombre))]
        public void ValidarActividadSinNombreErrorTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("", DateTime.Now, 1);

            modulo.ValidarActividad(actividad);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionActividadCostoInvalido))]
        public void ValidarActividadCostoInvalidoErrorTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("NombrePrueba", DateTime.MinValue, 0);

            modulo.ValidarActividad(actividad);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionActividadFechaInvalida))]
        public void ValidarActividadFechaInvalidaErrorTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("NombrePrueba", DateTime.MinValue, 10);

            modulo.ValidarActividad(actividad);
        }

        [TestMethod]
        public void AgregarParticipanteEnActividadTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionActividad moduloAct = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            ModuloGestionAlumno moduloAlu = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Actividad actividad = UtilidadesPruebas.CrearActividadDePrueba("ActividadAgregarParticipante", new DateTime(2018, 1, 1), 2000);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Carlitos", "Prueba", "1298637-8", "prueba@prueb.com", 78);
            moduloAct.Alta(actividad);
            moduloAlu.Alta(alumno);
            moduloAct.AgregarParticipanteEnActividad(actividad, alumno);
            Assert.IsTrue((moduloAct.ObtenerActividadPorId(actividad.Id).Participantes.Count > 0));
        }
        #endregion
        [TestMethod]
        public void ModificarActividadTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionActividad modulo = UtilidadesPruebas.CrearModuloGestionActividadDePrueba(repositorio);
            Actividad actividadOriginal = UtilidadesPruebas.CrearActividadDePrueba("ActividadPruebaOriginal", new DateTime(2017, 12, 24), 100);
            Actividad actividadNuevosDatos = UtilidadesPruebas.CrearActividadDePrueba("ActividadPruebaNuevosDatos", new DateTime(2018, 02, 20), 200);
            modulo.Alta(actividadOriginal);
            string nombreOriginal = actividadOriginal.Nombre;
            DateTime fechaOriginal = actividadOriginal.Fecha;
            modulo.ModificarActividad(ref actividadOriginal, actividadNuevosDatos);
            string nombreActualizado = modulo.ObtenerActividadPorId(actividadOriginal.Id).Nombre;
            DateTime fechaActualizado = modulo.ObtenerActividadPorId(actividadOriginal.Id).Fecha;

            Assert.IsTrue(!(nombreOriginal.Equals(nombreActualizado)) && (fechaOriginal.CompareTo(fechaActualizado) != 0));

        }
    }
}
