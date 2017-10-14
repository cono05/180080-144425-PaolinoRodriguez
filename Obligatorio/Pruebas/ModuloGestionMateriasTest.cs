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
       

      
        [TestMethod]
        public void AgregarMateriaTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", "an15");
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            //ModuloGestionMaterias modulo = ModuloGestionMaterias.ObtenerInstancia(repositorio);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 1);
        }

        [TestMethod]
        public void ObtenerMateriasTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", "an15");
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            //ModuloGestionMaterias modulo = ModuloGestionMaterias.ObtenerInstancia(repositorio);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 1);
        }




        [TestMethod]
        public void ExisteMateriaConMismoNombreTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", "an15");
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", "an16");
            modulo.Alta(materia1);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia1));
        }

        [TestMethod]
        public void ExisteMateriaConMismoNombreFalseTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", "an15");
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", "an16");
            modulo.Alta(materia1);
            Assert.IsFalse(modulo.ExisteMateriaConMismoNombre(materia2));
        }

        [TestMethod]
        public void ValidarMateriaOKTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", "an15");
            modulo.ValidarMateria(materia);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia));
        }
        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteMateriaConMismoNombre))]
        public void ValidarMateriaErrorNombreRepetidoTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", "an15");
            modulo.Alta(materia);
            modulo.ValidarMateria(materia);
        }

        [TestMethod]
        public void EsMateriaSinNombreTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1" , "an15");
            Assert.IsFalse(modulo.EsMateriaSinNombre(materia));
        }

        [TestMethod]
        public void EsMateriaSinNombreTrueTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("" , "an15");
            Assert.IsTrue(modulo.EsMateriaSinNombre(materia));
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionMateriaSinNombre))]
        public void ValidarMateriaSinNombreErrorTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("" , "an15");
            modulo.ValidarMateria(materia);
        }

        [TestMethod]
        public void ExisteMateriaConMismoCodigoTrueTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", "an15");
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ExisteMateriaConMismoCodigo(materia));
        }

        [TestMethod]
        public void ExisteMateriaConMismoCodigoFalseTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", "an15");
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", "an19");
            modulo.Alta(materia);
            Assert.IsFalse(modulo.ExisteMateriaConMismoCodigo(materia2));
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionMateriaCodigoRepetido))]
        public void ValidarMateriaCodigoRepetidoErrorTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", "an15");
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", "an15");
            modulo.Alta(materia);
            modulo.ValidarMateria(materia2);
        }

        [TestMethod]
        public void AgregarAlumnoEnMateriaTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", "an15");
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(materia.Alumnos.Count == 1);
        }

       

        [TestMethod]
        public void EstaInscriptoEnLaMateriaTrueTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", "an15");
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(modulo.EstaInscriptoEnLaMateria(materia, alumno));
        }

        [TestMethod]
        public void EstaInscriptoEnLaMateriaFalseTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", "an15");
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsFalse(modulo.EstaInscriptoEnLaMateria(materia, alumno2));
        }


        [TestMethod]
        public void TienenMismoNumeroEstudianteFalseTest()
        {
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Assert.IsFalse(modulo.TienenMismoNumeroEstudiante(alumno, alumno2));
        }

        [TestMethod]
        public void TienenMismoNumeroEstudianteTrueTest()
        {
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 111222);
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Assert.IsTrue(modulo.TienenMismoNumeroEstudiante(alumno, alumno2));
        }

        [TestMethod]
        public void BajaTest()
        {
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba();
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", "an10");
            modulo.Alta(materia);
            modulo.Baja(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 0);            
        }
    }
}
