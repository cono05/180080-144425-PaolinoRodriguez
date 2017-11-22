using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class RepositorioBDTest
    {
        [TestInitialize]
        public void TestInitialize() {
            UtilidadesPruebas.VaciarTablas();
        }
        
            
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
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            modulo.Alta(docente);
            Assert.IsTrue(modulo.ObtenerDocentes().Contains(docente));
        }
        [TestMethod]
        public void AgregarMateriaTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            Assert.IsTrue(moduloMaterias.ExisteMateriaConMismoCodigo(materia));
        }

        [TestMethod]
        public void EliminarMateriaTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            moduloMaterias.Baja(materia);
            Assert.IsTrue(moduloMaterias.ObtenerMaterias().Count == 0);
        }

        [TestMethod]
        public void ObtenerMateriaPorCodigoTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            Materia materia2 = repositorio.ObtenerMateriaPorCodigo(materia.Codigo);
            Assert.AreEqual(materia.Codigo, materia2.Codigo);
        }

        [TestMethod]
        public void ModificarMateriaTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño22", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            moduloMaterias.ModificarMateria(materia, "Diseño22");
            materia = repositorio.ObtenerMateriaPorCodigo(materia.Codigo);
            Assert.IsTrue(materia.Nombre.Equals("Diseño22"));
        }

        [TestMethod]
        public void ObtenerMateriasTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
        }

        [TestMethod]
        public void ObtenerAlumnosDeLaMateriaTestBD()
        {
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
        public void AgregarDocenteEnMateriaTestBD()
        {
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

        [TestMethod]
        public void ObtenerDocentesDeLaMateriaTestBD()
        {
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

        [TestMethod]
        public void EliminarDocenteEnMateriaTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 1000);
            ModuloGestionMaterias moduloMaterias = new ModuloGestionMaterias(repositorio);
            moduloMaterias.Alta(materia);
            ModuloGestionDocente moduloDocentes = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Pedro", "Leon", "5654543-1");
            moduloDocentes.Alta(docente);
            repositorio.AgregarDocenteEnMateria(materia, docente);
            repositorio.EliminarDocenteEnMateria(materia, docente);
            Assert.IsTrue(repositorio.ObtenerDocentesDeLaMateria(materia).Count==0);
        }

        [TestMethod]
        public void ModificarAlumnoTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("NombreNuevo", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(repositorio);
            modulo.Alta(alumno);
            repositorio.ModificarAlumno(alumno, alumno2);
            alumno = repositorio.ObtenerAlumnoPorID(alumno.Id);
            Assert.IsTrue(alumno.Nombre.Equals("NombreNuevo"));
        }

        [TestMethod]
        public void ObtenerAlumnoPorIDTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(repositorio);
            modulo.Alta(alumno);
            Alumno obtenido = repositorio.ObtenerAlumnoPorID(alumno.Id);
            Assert.AreEqual(alumno.Id, obtenido.Id);
        }

        [TestMethod]
        public void EliminarDocenteTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            modulo.Alta(docente);
            repositorio.EliminarDocente(docente);
            Assert.IsTrue(modulo.ObtenerDocentes().Count == 0);
        }

        [TestMethod]
        public void EliminarAlumnoTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(repositorio);
            modulo.Alta(alumno);
            modulo.Baja(alumno);
            Assert.IsTrue(modulo.ObtenerAlumnos().Count == 0);
        }
        [TestMethod]
        public void ObtenerDocentePorIDTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            modulo.Alta(docente);
            Docente obtenidoPorID = repositorio.ObtenerDocentePorID(docente.Id);
            Assert.AreEqual(docente.Id, obtenidoPorID.Id);
        }


        [TestMethod]
        public void ModificarDocenteTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba(repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre22", "Apellido22", "0000000-1");
            modulo.Alta(docente);
            modulo.ModificarDocente(ref docente, docente2);
            docente = repositorio.ObtenerDocentePorID(docente.Id);
            Assert.IsTrue(docente.Nombre.Equals("Nombre22"));
        }

        [TestMethod]
        public void AgregarCamionetaTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(repositorio);
            moduloCamionetas.Nombre = "moduloCamionetas";
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("", "AAA1515", 20, 10);
            repositorio.AgregarCamioneta(camioneta);
            Assert.IsTrue(moduloCamionetas.ObtenerCamionetas().Contains(camioneta));
        }

        [TestMethod]
        public void EliminarCamionetaTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("", "AAA1515", 20, 10);
            repositorio.AgregarCamioneta(camioneta);
            repositorio.EliminarCamioneta(camioneta);
            Assert.IsTrue(moduloCamionetas.ObtenerCamionetas().Count == 0);
        }

        [TestMethod]
        public void ObtenerCamionetasOrdenadasPorRendimientoTest()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionCamioneta moduloCamionetas = UtilidadesPruebas.CrearModuloGestionCamionetaDePrueba(repositorio);
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 10, 5);
            repositorio.AgregarCamioneta(camioneta);
            Camioneta camioneta2 = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA2020", 20, 5);
            repositorio.AgregarCamioneta(camioneta2);
            List<Camioneta> camionetas = repositorio.ObtenerCamionetasPorRendimiento();
            Assert.IsTrue(camionetas[0].Chapa.Equals("AAA2020"));
        }

        [TestMethod]
        public void VaciarTablasTestBD()
        {
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            Camioneta camioneta = UtilidadesPruebas.CrearCamionetaDePrueba("Ford", "AAA1515", 10, 5);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Algoritmos", 1520);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-1", "nombreapellido@gmail.com", 1);
            repositorio.AgregarCamioneta(camioneta);
            repositorio.AgregarDocente(docente);
            repositorio.AgregarAlumno(alumno);
            repositorio.AgregarMateria(materia);
            repositorio.VaciarTablas();
            bool baseVacia = repositorio.ObtenerAlumnos().Count == 0 && repositorio.ObtenerMaterias().Count == 0
                            && repositorio.ObtenerDocentes().Count == 0 && repositorio.ObtenerCamionetas().Count == 0;
            Assert.IsTrue(baseVacia);
        }
    }   
}
