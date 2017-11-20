using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
namespace Pruebas
{
    [TestClass]
    public class RepositorioBDTest
    {
        [TestMethod]
        public void AgregarAlumnoTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(repositorio);
            modulo.Alta(alumno);
            Assert.IsTrue(modulo.ObtenerAlumnos().Contains(alumno));
        }

        [TestMethod]
        public void AgregarAlumnoEnMateriaBDTest()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "6765476-1", "nombreapellido2@gmail.com", 1);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionAlumno moduloAlumnos = new ModuloGestionAlumno(repositorio);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloAlumnos.Alta(alumno);
            moduloMaterias.Alta(materia);
            repositorio.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(repositorio.ObtenerAlumnosDeLaMateria(materia).Contains(alumno));
        }


    }
}
