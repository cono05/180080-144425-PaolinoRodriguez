using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionAlumnoTest
    {
        [TestMethod]
        public void AgregarAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(ref repositorio);
            modulo.Alta(alumno);
            Assert.IsTrue(repositorio.Alumnos.Count == 1);
        }

        [TestMethod]
        public void EliminarAlumnoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "m@g.com", 7);
            modulo.Alta(alumno);
            int antesEliminar = modulo.repositorio.Alumnos.Count;
            modulo.Baja(alumno);
            int despuesEliminar = modulo.repositorio.Alumnos.Count;
            Assert.IsTrue(antesEliminar == despuesEliminar + 1);
        }

        [TestMethod]
        public void ExisteAlumnoConMismoNumeroEstudianteTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsTrue(modulo.ExisteAlumnoConMismoNumeroEstudiante(alumno1));
        }

        [TestMethod]
        public void ExisteAlumnoConMismoNumeroEstudianteFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsFalse(modulo.ExisteAlumnoConMismoNumeroEstudiante(alumno2));
        }

        [TestMethod]
        public void EsAlumnoSinNombreTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinNombre(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinNombreFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinNombre(alumno));
        }


        [TestMethod]
        public void EsAlumnoSinApellidoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinApellido(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinApellidoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinApellido(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinCedula(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinCedula(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinEmailTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "", 1);
            Assert.IsTrue(modulo.EsAlumnoSinEmail(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinEmailFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinEmail(alumno));
        }

        [TestMethod]
        public void ValidarAlumnoSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        public void ValidarAlumnoSinApellidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        public void ValidarAlumnoSinCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        public void ValidarAlumnoSinEmailErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        public void EsFormatoCedulaAlumnoCorrectoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-8", "na@gmail.com", 4);
            Assert.IsTrue(modulo.EsFormatoCedulaAlumnoCorrecto(alumno));
        }

        [TestMethod]
        public void EsFormatoCedulaAlumnoCorrectoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "12345-8", "na@gmail.com", 5);
            Assert.IsFalse(modulo.EsFormatoCedulaAlumnoCorrecto(alumno));
        }
    }
}
