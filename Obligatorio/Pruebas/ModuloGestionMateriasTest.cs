﻿using System;
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
        public void GetNombreModulotest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            modulo.Nombre = "moduloMaterias";
            Assert.AreEqual("moduloMaterias", modulo.Nombre);
        }

        [TestMethod]
        public void GetDescripcionTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            modulo.Descripcion = "descripcion";
            Assert.AreEqual("descripcion", modulo.Descripcion);
        }

        [TestMethod]
        public void AgregarMateriaTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            //ModuloGestionMaterias modulo = ModuloGestionMaterias.ObtenerInstancia(repositorio);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 1);

        }
        
        [TestMethod]
        public void ObtenerMateriasTest()
        {
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            //ModuloGestionMaterias modulo = ModuloGestionMaterias.ObtenerInstancia(repositorio);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 1);
        }

        [TestMethod]
        public void ModificarMateriaTest()
        {
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            modulo.Alta(materia);
            string nombreViejo = materia.Nombre;
            string datos = materia.Nombre;
            modulo.ModificarMateria(materia, datos);
            Assert.IsTrue(nombreViejo.Equals(materia.Nombre));
        }

        [TestMethod]
        public void ModificarMateriaFalseTest()
        {
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            modulo.Alta(materia);
            string nombreViejo = materia.Nombre;
            string datos = "Ingenieria de Software 2";
            modulo.ModificarMateria(materia, datos);
            Assert.IsFalse(nombreViejo.Equals(materia.Nombre));
        }

        [TestMethod]
        public void ExisteMateriaConMismoNombreTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 16);
            modulo.Alta(materia1);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia1));
        }
       

        [TestMethod]
        public void ExisteMateriaConMismoNombreFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia1 = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", 16);
            modulo.Alta(materia1);
            Assert.IsFalse(modulo.ExisteMateriaConMismoNombre(materia2));
        }
       

        [TestMethod]
        public void ValidarMateriaOKTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            modulo.ValidarAltaMateria(materia);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ExisteMateriaConMismoNombre(materia));
        }
        

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteMateriaConMismoNombre))]
        public void ValidarMateriaErrorNombreRepetidoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            modulo.Alta(materia);
            modulo.ValidarAltaMateria(materia);
        }
        

        [TestMethod]
        public void EsMateriaSinNombreTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño1", 15);
            Assert.IsFalse(modulo.EsMateriaSinNombre(materia));
        }
        

        [TestMethod]
        public void EsMateriaSinNombreTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("", 15);
            Assert.IsTrue(modulo.EsMateriaSinNombre(materia));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ExcepcionMateriaSinNombre))]
        public void ValidarMateriaSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("", 15);
            modulo.ValidarAltaMateria(materia);
        }
       

        [TestMethod]
        public void ExisteMateriaConMismoCodigoTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            Assert.IsTrue(modulo.ExisteMateriaConMismoCodigo(materia));
        }
        

        [TestMethod]
        public void ExisteMateriaConMismoCodigoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", 16);
            modulo.Alta(materia);
            Assert.IsFalse(modulo.ExisteMateriaConMismoCodigo(materia2));
        }
        

        [TestMethod]
        [ExpectedException(typeof(ExcepcionMateriaCodigoRepetido))]
        public void ValidarMateriaCodigoRepetidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", 15);
            modulo.Alta(materia);
            materia2.Codigo = materia.Codigo;
            modulo.ValidarAltaMateria(materia2);
        }
        

        [TestMethod]
        public void AgregarAlumnoEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(materia.Alumnos.Count == 1);
        }
        

        [TestMethod]
        public void EstaInscriptoEnLaMateriaTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
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
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsFalse(modulo.EstaInscriptoEnLaMateria(materia, alumno2));
        }

        

        [TestMethod]
        public void TienenMismoNumeroEstudianteFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 222222);
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Assert.IsFalse(modulo.TienenMismoNumeroEstudiante(alumno, alumno2));
        }
        

        [TestMethod]
        public void TienenMismoNumeroEstudianteTrueTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "22226789", "m@g.com", 111222);
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Assert.IsTrue(modulo.TienenMismoNumeroEstudiante(alumno, alumno));
        }
        

        [TestMethod]
        public void BajaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            modulo.Alta(materia);
            modulo.Baja(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNoExisteMateriaConEseCodigo))]
        public void BajaMateriaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            modulo.Baja(materia);
            Assert.IsTrue(modulo.ObtenerMaterias().Count == 0);
        }
       

        [TestMethod]
        public void EliminarAlumnoDeUnaMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "123456789", "m@g.com", 111222);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            modulo.EliminarAlumnoDeUnaMateria(materia, alumno);
            Assert.IsTrue(materia.Alumnos.Count == 0);
        }

     

        [TestMethod]
        public void EliminarMateriaEnCadaAlumnoInscriptoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "1234567-8", "m@g.com", 111222);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "1554567-0", "m@h.com", 111333);
            moduloMaterias.Alta(materia);
            moduloAlumnos.Alta(alumno);
            moduloAlumnos.Alta(alumno2);
            moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
            moduloMaterias.AgregarAlumnoEnMateria(materia, alumno2);
            moduloMaterias.EliminarMateriaEncadaAlumnoInscripto(materia);
            Assert.IsTrue(alumno.MateriasInscripto.Count == 0 && alumno2.MateriasInscripto.Count == 0);
        }

        [TestMethod]
        public void HayMateriasRegistradasTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 10);
            moduloMaterias.Alta(materia);
            Assert.IsTrue(moduloMaterias.HayMateriasRegistradas());
        }

        [TestMethod]
        public void HayMateriasRegistradasFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Assert.IsFalse(moduloMaterias.HayMateriasRegistradas());
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoYaCursaLaMateria))]
        public void ValidarInscripcionDeAlumnoEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "1234567-9", "m@g.com", 111222);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            modulo.Alta(materia);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
            modulo.AgregarAlumnoEnMateria(materia, alumno);
        }

        [TestMethod]
        public void ObtenerAlumnosTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "1234567-9", "m@g.com", 111222);
            moduloAlumnos.Alta(alumno);
            Assert.IsTrue(modulo.ObtenerAlumnos().Count == 1);
        }

        [TestMethod]
        public void ObtenerAlumnosInscriptosEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio); Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "1234567-9", "m@g.com", 111222);
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            moduloAlumnos.Alta(alumno);
            moduloMaterias.AgregarAlumnoEnMateria(materia, alumno);
            Assert.IsTrue(moduloMaterias.ObtenerAlumnosInscriptosEnMateria(materia).Count == 1);            
        }

        [TestMethod]
        public void AsignarDocenteAMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Jose", "Diaz", "1234567-8");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            moduloMaterias.Alta(materia);
            moduloDocente.Alta(docente);
            moduloMaterias.AsignarDocenteAMateria(materia, docente);
            Assert.IsTrue(materia.Docentes.Contains(docente));
        }

        [TestMethod]
        public void EsDocenteDeLaMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Jose", "Diaz", "1234567-8");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            moduloMaterias.Alta(materia);
            moduloDocente.Alta(docente);
            moduloMaterias.AsignarDocenteAMateria(materia, docente);
            Assert.IsTrue(moduloMaterias.EsDocenteDeLaMateria(materia, docente));
        }
        [TestMethod]
        public void EsDocenteDeLaMateriaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Jose", "Diaz", "1234567-8");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            moduloMaterias.Alta(materia);
            moduloDocente.Alta(docente);
            Assert.IsFalse(moduloMaterias.EsDocenteDeLaMateria(materia, docente));
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteYaDictaEstaMateria))]
        public void ValidarAsignacionDeDocenteAMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Jose", "Diaz", "1234567-8");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            moduloMaterias.Alta(materia);
            moduloDocente.Alta(docente);
            moduloMaterias.AsignarDocenteAMateria(materia, docente);
            moduloMaterias.ValidarAsignacionDeDocenteAMateria(materia, docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteMateriaConMismoNombre))]
        public void ValidarModifcacionNombreMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            Materia materia2 = UtilidadesPruebas.CrearMateriaDePueba("Diseño2", 15);
            moduloMaterias.Alta(materia);
            moduloMaterias.ValidarModificacionNombreMateria(materia2, "Diseño");
        }

        [TestMethod]
        public void ObtenerDocentesDeLaMateriaTest() //ESTA PRUEBA FALLA PORQ HAY Q VACIAR LAS TABLAS ANTES DE ENTRAR
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumnos = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba( repositorio);
            ModuloGestionMaterias moduloMaterias = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Jose", "Diaz", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Diego", "Lopez", "1258867-8");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño", 15);
            moduloMaterias.Alta(materia);
            moduloDocente.Alta(docente);
            moduloDocente.Alta(docente2);
            moduloMaterias.AsignarDocenteAMateria(materia, docente);
            moduloMaterias.AsignarDocenteAMateria(materia, docente2);
            Assert.IsTrue(moduloMaterias.ObtenerDocentesDeUnaMateria(materia).Count == 2);
        }

        [TestMethod]
        public void ObtenerMateriaPorCodigoTest()
        {
            UtilidadesPruebas.VaciarTablas();
            RepositorioBD repositorio = UtilidadesPruebas.CrearRepositorioBDPrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Algebra", 98);
            modulo.Alta(materia);
            Materia materiaAux = modulo.ObtenerMateriaPorCodigo(materia.Codigo);
            
            Assert.IsTrue(materiaAux.Codigo == materia.Codigo);
        }

        [TestMethod]
        public void ObtenerMateriaPorCodigoTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(repositorio);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Algebra", 98);
            modulo.Alta(materia);
            Materia materiaAux = modulo.ObtenerMateriaPorCodigo(materia.Codigo);
            Assert.IsTrue(materiaAux.Codigo == materia.Codigo);
        }

        [TestMethod]
        public void ObtenerMateriaPorCodigoNoExistenteTestRam()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionMaterias modulo = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(repositorio);
            Materia materiaAux = modulo.ObtenerMateriaPorCodigo(10);
            Assert.IsTrue(materiaAux == null);
        }
    }
}




    


