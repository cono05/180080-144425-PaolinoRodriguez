using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionAlumnoTest
    {

        [TestMethod]
        public void GetNombreModuloGestionAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            moduloAlumno.Nombre = "moduloAlumno";
            Assert.AreEqual("moduloAlumno", moduloAlumno.Nombre);
        }

        [TestMethod]
        public void GetDescripcionModuloGestionAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            moduloAlumno.Descripcion = "moduloDescripcion";
            Assert.AreEqual("moduloDescripcion", moduloAlumno.Descripcion);
        }

        [TestMethod]
        public void AgregarAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(repositorio);
            modulo.Alta(alumno);
            Assert.IsTrue(modulo.ObtenerAlumnos().Count == 1);
        }

        [TestMethod]
        public void EliminarAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "m@g.com", 7);
            modulo.Alta(alumno);
            int antesEliminar = modulo.ObtenerAlumnos().Count;
            modulo.Baja(alumno);
            int despuesEliminar = modulo.ObtenerAlumnos().Count;
            Assert.IsTrue(antesEliminar == despuesEliminar + 1);
        }

        [TestMethod]
        public void ObtenerAlumnosTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "m@g.com", 7);
            modulo.Alta(alumno);
            Assert.IsTrue(modulo.ObtenerAlumnos().Count == 1);
        }

        [TestMethod]
        public void ModificarAlumno1Test()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumnoOriginal = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            Alumno alumnoNuevosDatos = UtilidadesPruebas.CrearAlumnoDePrueba("NombreNuevo", "ApellidoNuevo", "1234567-8", "np@mail.com", 1);
            modulo.Alta(alumnoOriginal);
            string nombreOriginal = alumnoOriginal.Nombre;
            string apellidoOriginal = alumnoOriginal.Apellido;
            modulo.ModificarAlumno( ref alumnoOriginal, alumnoNuevosDatos);
            string nombreActualizado = alumnoOriginal.Nombre;
            string apellidoActualizado = alumnoOriginal.Apellido;
            Assert.IsTrue(!(nombreOriginal.Equals(nombreActualizado)) && !(apellidoOriginal.Equals(apellidoActualizado)));
        }

        [TestMethod]
        public void ModificarAlumno2Test()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumnoOriginal = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            Alumno alumnoNuevosDatos = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            modulo.Alta(alumnoOriginal);
            string nombreOriginal = alumnoOriginal.Nombre;
            string apellidoOriginal = alumnoOriginal.Apellido;
            modulo.ModificarAlumno(ref alumnoOriginal, alumnoNuevosDatos);
            string nombreActualizado = alumnoOriginal.Nombre;
            string apellidoActualizado = alumnoOriginal.Apellido;
            Assert.IsFalse(!(nombreOriginal.Equals(nombreActualizado)) && !(apellidoOriginal.Equals(apellidoActualizado)));
        }

        [TestMethod]
        public void EliminarAlumnoInscritoEnMateriasTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            Alumno alumno   = UtilidadesPruebas.CrearAlumnoDePrueba("Maxi", "Ramirez", "3234256-7", "mr@mail.com", 9);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño Aplicaciones 1", 1);
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(repositorio);
            moduloAlumno.Alta(alumno);
            moduloMateria.Alta(materia);
            moduloAlumno.InscribirAlumnoEnMateria(alumno, materia);
            int antesEliminar = moduloAlumno.ObtenerAlumnos().Count;
            moduloAlumno.Baja(alumno);
            int despuesEliminar = moduloAlumno.ObtenerAlumnos().Count;
            Assert.IsTrue(antesEliminar == despuesEliminar + 1);
        }

        [TestMethod]
        public void ExisteAlumnoConMismoNumeroEstudianteTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsTrue(modulo.ExisteAlumnoConMismoNumeroEstudiante(alumno1));
        }

        [TestMethod]
        public void ExisteAlumnoConMismoNumeroEstudianteFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsFalse(modulo.ExisteAlumnoConMismoNumeroEstudiante(alumno2));
        }

        [TestMethod]
        public void ExisteAlumnoConMismoEmailTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre1apellido1@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsTrue(modulo.ExisteAlumnoConMismoEmail(alumno2));
        }

        [TestMethod]
        public void ExisteAlumnoConMismoEmailFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsFalse(modulo.ExisteAlumnoConMismoEmail(alumno2));
        }

        [TestMethod]
        public void EsAlumnoSinNombreTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinNombre(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinNombreFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinNombre(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinApellidoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinApellido(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinApellidoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinApellido(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinCedula(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinCedula(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinEmailTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "", 1);
            Assert.IsTrue(modulo.EsAlumnoSinEmail(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinEmailFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinEmail(alumno));
        }
       
        #region ValidacionesTest
        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinNombre))]
        public void ValidarAlumnoSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinApellido))]
        public void ValidarAlumnoSinApellidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinCedula))]
        public void ValidarAlumnoSinCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinEmail))]
        public void ValidarAlumnoSinEmailErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionFormatoCedulaIncorrecto))]
        public void ValidarFormatoCedulaIncorrecto()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0004h00-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteAlumnoConMismaCedula))]
        public void ValidarExisteAlumnoConMismaCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 2);
            modulo.Alta(alumno1);
            modulo.ValidarAlumno(alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteAlumnoConMismoEmail))]
        public void ValidarExisteAlumnoConMismoEmail()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0111010-3", "apellido@gmail.com", 2);
            modulo.Alta(alumno1);
            modulo.ValidarAlumno(alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinNombre))]
        public void ValidarModificarAlumnoSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarModificarAlumno(alumno1, alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinApellido))]
        public void ValidarModificarAlumnoSinApellidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarModificarAlumno(alumno1, alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinCedula))]
        public void ValidarModificarAlumnoSinCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Ape", "", "apellido@gmail.com", 1);
            modulo.ValidarModificarAlumno(alumno1, alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinEmail))]
        public void ValidarModificarAlumnoSinEmailErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Ape", "1234567-8", "", 1);
            modulo.ValidarModificarAlumno(alumno1, alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionFormatoCedulaIncorrecto))]
        public void ValidarModificarAlumnoFormatoCedulaIncorrectoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Ape", "1567-8", "asd@gmail.com", 1);
            modulo.ValidarModificarAlumno(alumno1, alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteAlumnoConMismaCedula))]
        public void ValidarModificarAlumnoExisteAlumnoConMismaCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.Alta(alumno1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Ape", "1567-8", "asd@gmail.com", 2);
            Alumno alumno3 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "ape", "0000000-3", "emilio@email.com", 3);
            modulo.ValidarModificarAlumno(alumno2, alumno3);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteAlumnoConMismoEmail))]
        public void ValidarModificarAlumnoExisteAlumnoConMismoEmailErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.Alta(alumno1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Ape", "1567-8", "asd@gmail.com", 2);
            Alumno alumno3 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "ape", "0000000-3", "apellido@gmail.com", 3);
            modulo.ValidarModificarAlumno(alumno2, alumno3);
        }
        #endregion Validaciones test

        [TestMethod]
        public void EsFormatoCedulaAlumnoCorrectoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-8", "na@gmail.com", 4);
            Assert.IsTrue(modulo.EsFormatoCedulaAlumnoCorrecto(alumno.Cedula));
        }

        [TestMethod]
        public void EsFormatoCedulaAlumnoCorrectoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "12345-8", "na@gmail.com", 5);
            Assert.IsFalse(modulo.EsFormatoCedulaAlumnoCorrecto(alumno.Cedula));
        }

        [TestMethod]
        public void InscribirAlumnoEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Alumno alumno   = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño de Aplicaciones 1", 030);
            moduloAlumno.InscribirAlumnoEnMateria(alumno, materia);
            Assert.IsTrue(moduloMateria.EstaInscriptoEnLaMateria(materia, alumno));
        }

        [TestMethod]
        public void DesinscribirAlumnoEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño de Aplicaciones 1", 030);
            moduloAlumno.InscribirAlumnoEnMateria(alumno, materia);
            moduloAlumno.DesincribirAlumnoEnMateria(alumno, materia);
            Assert.IsTrue(alumno.MateriasInscripto.Count == 0);
        }

        [TestMethod]
        public void EstaAlumnoInscritoEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño de Aplicaciones 1", 030);

            Assert.IsFalse(moduloAlumno.EstaAlumnoInscritoEnMateria(alumno, materia));

        }

        [TestMethod]
        public void EstaAlumnoInscritoEnMateriaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño de Aplicaciones 1", 030);
            moduloAlumno.InscribirAlumnoEnMateria(alumno, materia);

            Assert.IsTrue(moduloAlumno.EstaAlumnoInscritoEnMateria(alumno, materia));

        }

        [TestMethod]
        public void ExisteAlumnoConMismaCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-1", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsTrue(modulo.ExisteAlumnoConMismaCedula(alumno1.Cedula));
        }

        [TestMethod]
        public void ExisteAlumnoConMismaCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsFalse(modulo.ExisteAlumnoConMismaCedula(alumno2.Cedula));
        }

        [TestMethod]
        public void EsValidoMailAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Assert.IsTrue(modulo.EsValidoMailAlumno(alumno1.Mail));
        }

        [TestMethod]
        public void EsValidoMailAlumnoTestFalse()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "mail.com", 1);
            Assert.IsFalse(modulo.EsValidoMailAlumno(alumno1.Mail));
        }
    }
}

