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
    }
}
