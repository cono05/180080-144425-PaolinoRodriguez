using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionMateriasTest
    {

        private RepositorioRam repositorio;


        [TestMethod]
        public void AgregarMateriaTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            //ModuloGestionMaterias modulo = ModuloGestionMaterias.ObtenerInstancia(repositorio);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 1);

        }
        [TestCleanup]

        [TestMethod]
        public void ObtenerMateriasTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            //ModuloGestionMaterias modulo = ModuloGestionMaterias.ObtenerInstancia(repositorio);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 1);
        }
        [TestCleanup]



        [TestMethod]
        public void ExisteMateriaConMismoNombreTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 16);
            modulo.Alta(materia1);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia1));
        }
        [TestCleanup]

        [TestMethod]
        public void ExisteMateriaConMismoNombreFalseTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", 16);
            modulo.Alta(materia1);
            Assert.IsFalse(modulo.ExisteMateriaConMismoNombre(materia2));
        }
        [TestCleanup]

        [TestMethod]
        public void ValidarMateriaOKTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            modulo.ValidarAltaMateria(materia);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia));
        }
        [TestCleanup]

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteMateriaConMismoNombre))]
        public void ValidarMateriaErrorNombreRepetidoTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            modulo.Alta(materia);
            modulo.ValidarAltaMateria(materia);
        }
        [TestCleanup]

        [TestMethod]
        public void EsMateriaSinNombreTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Assert.IsFalse(modulo.EsMateriaSinNombre(materia));
        }
        [TestCleanup]

        [TestMethod]
        public void EsMateriaSinNombreTrueTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("", 15);
            Assert.IsTrue(modulo.EsMateriaSinNombre(materia));
        }
        [TestCleanup]

        [TestMethod]
        [ExpectedException(typeof(ExcepcionMateriaSinNombre))]
        public void ValidarMateriaSinNombreErrorTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("", 15);
            modulo.ValidarAltaMateria(materia);
        }
        [TestCleanup]

        [TestMethod]
        public void ExisteMateriaConMismoCodigoTrueTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ExisteMateriaConMismoCodigo(materia));
        }
        [TestCleanup]

        [TestMethod]
        public void ExisteMateriaConMismoCodigoFalseTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", 16);
            modulo.Alta(materia);
            Assert.IsFalse(modulo.ExisteMateriaConMismoCodigo(materia2));
        }
        [TestCleanup]

        [TestMethod]
        [ExpectedException(typeof(ExcepcionMateriaCodigoRepetido))]
        public void ValidarMateriaCodigoRepetidoErrorTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", 15);
            modulo.Alta(materia);
            modulo.ValidarAltaMateria(materia2);
        }
        [TestCleanup]

        [TestMethod]
        public void AgregarAlumnoEnMateriaTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(materia.Alumnos.Count == 1);
        }
        [TestCleanup]

        [TestMethod]
        public void EstaInscriptoEnLaMateriaTrueTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(modulo.EstaInscriptoEnLaMateria(materia, alumno));
        }
        [TestCleanup]

        [TestMethod]
        public void EstaInscriptoEnLaMateriaFalseTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsFalse(modulo.EstaInscriptoEnLaMateria(materia, alumno2));
        }

        [TestCleanup]

        [TestMethod]
        public void TienenMismoNumeroEstudianteFalseTest()
        {
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Assert.IsFalse(modulo.TienenMismoNumeroEstudiante(alumno, alumno2));
        }
        [TestCleanup]

        [TestMethod]
        public void TienenMismoNumeroEstudianteTrueTest()
        {
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 111222);
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Assert.IsTrue(modulo.TienenMismoNumeroEstudiante(alumno, alumno2));
        }
        [TestCleanup]

        [TestMethod]
        public void BajaTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            modulo.Alta(materia);
            modulo.Baja(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNoExisteMateriaConEseCodigo))]
        public void BajaMateriaErrorTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            modulo.Baja(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 0);
        }
        [TestCleanup]

        [TestMethod]
        public void EliminarAlumnoDeUnaMateriaTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            ModuloGestionMaterias.EliminarAlumnoDeUnaMateria(materia, alumno);
            Assert.IsTrue(materia.Alumnos.Count == 0);
        }
<<<<<<< HEAD
        [TestCleanup()]

        [TestMethod]
        public void EliminarMateriaEnCadaAlumnoInscriptoTest()
        {
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456780", "m@h.com", 111333);
            moduloMaterias.Alta(materia);
            moduloAlumnos.Alta(alumno);
            moduloAlumnos.Alta(alumno2);
            moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
            moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
            moduloMaterias.EliminarMateriaEncadaAlumnoInscripto(materia);
            Assert.IsTrue(alumno.MateriasInscripto.Count == 0);
        }
        
    }
}




    

=======
    }
}
>>>>>>> 7a3c425b1fe04a370530024d330c18aa0f6a7eb4
