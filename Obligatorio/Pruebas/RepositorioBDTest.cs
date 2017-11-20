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

        [TestMethod]
        public void EliminarAlumnoDeMateriaBDTest()
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
            repositorio.EliminarAlumnoDeMateria(materia, alumno);
            Assert.IsFalse(repositorio.ObtenerAlumnosDeLaMateria(materia).Contains(alumno));
        }

        [TestMethod]
        public void AgregarDocenteTestBD()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            modulo.Alta(docente);
            Assert.IsTrue(modulo.ObtenerDocentes().Contains(docente));
        }
        [TestMethod]
        public void AgregarMateriaTestBD()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            Assert.IsTrue(moduloMaterias.ObtenerMaterias().Contains(materia));
        }

        [TestMethod]
        public void ObtenerMateriasTestBD()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
        }

        [TestMethod]
        public void ObtenerAlumnosDeLaMateriaTestBD()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "0000000-1", "nombreapellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Pedro", "Perez", "2222222-2", "nombreapellido22@gmail.com", 21);
            ModuloGestionAlumno moduloAlumnos = new ModuloGestionAlumno(repositorio);
            moduloAlumnos.Alta(alumno);
            moduloAlumnos.Alta(alumno2);
            repositorio.AgregarAlumnoEnMateria(materia, alumno2);
            repositorio.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(repositorio.ObtenerAlumnosDeLaMateria(materia).Count == 2);
        }

        [TestMethod]
        public void ObtenerDocentesDeLaMateriaTestBD()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            ModuloGestionDocente moduloDocentes = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Pedro", "Leon", "5654543-1");
            moduloDocentes.Alta(docente);
            repositorio.AgregarDocenteEnMateria(materia, docente);
            Assert.IsTrue(repositorio.ObtenerDocentesDeLaMateria(materia).Contains(docente));
        }
   }
}
