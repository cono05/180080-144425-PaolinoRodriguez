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
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(repositorio);
            modulo.Alta(alumno);
            Assert.IsTrue(repositorio.Alumnos.Count == 1);
        }

        [TestMethod]
        public void ExisteAlumnoConMismoNumeroEstudianteTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsTrue(modulo.ExisteAlumnoConMismoNumeroEstudiante(alumno1));
        }

        [TestMethod]
        public void ExisteAlumnoConMismoNumeroEstudianteFalseTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsFalse(modulo.ExisteAlumnoConMismoNumeroEstudiante(alumno2));
        }

        [TestMethod]
        public void EsAlumnoSinNombreTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinNombre(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinNombreFalseTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinNombre(alumno));
        }


        [TestMethod]
        public void EsAlumnoSinApellidoTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinApellido(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinApellidoFalseTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinApellido(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinCedulaTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "apellido@gmail.com", 1);
            Assert.IsTrue(modulo.EsAlumnoSinCedula(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinCedulaFalseTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinCedula(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinEmailTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "", 1);
            Assert.IsTrue(modulo.EsAlumnoSinEmail(alumno));
        }

        [TestMethod]
        public void EsAlumnoSinEmailFalseTest()
        {
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Assert.IsFalse(modulo.EsAlumnoSinEmail(alumno));
        }

    }
}
