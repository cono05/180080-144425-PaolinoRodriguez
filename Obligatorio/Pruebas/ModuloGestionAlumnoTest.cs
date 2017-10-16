﻿using System;
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
        public void ModificarAlumno1Test()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            modulo.Alta(alumno);
            string nombreViejo = alumno.Nombre;
            string datos = alumno.Nombre + ";" + alumno.Apellido + ";" + alumno.Cedula + ";" + alumno.Mail;
            modulo.ModificarAlumno(alumno, datos);
            Assert.IsTrue(nombreViejo.Equals(alumno.Nombre));
        }

        [TestMethod]
        public void ModificarAlumno2Test()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            modulo.Alta(alumno);
            string nombreViejo = alumno.Nombre;
            string datos = alumno.Nombre + ";" + alumno.Apellido + ";" + "3333333-3" + ";" + alumno.Mail;
            modulo.ModificarAlumno(alumno, datos);
            Assert.IsTrue(nombreViejo.Equals(alumno.Nombre));
        }

        [TestMethod]
        public void ModificarAlumnoFail1Test()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            modulo.Alta(alumno);
            string nombreViejo = alumno.Nombre;
            string datos = "Carlitos" + ";" + alumno.Apellido + ";" + alumno.Cedula + ";" + alumno.Mail;
            modulo.ModificarAlumno(alumno, datos);
            Assert.IsFalse(nombreViejo.Equals(alumno.Nombre));
        }

        [TestMethod]
        public void ModificarAlumnoFail2Test()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            modulo.Alta(alumno);
            string nombreViejo   = alumno.Nombre;
            string apellidoViejo = alumno.Apellido;
            string datos = "Carlitos" + ";" + "Rondan" + ";" + alumno.Cedula + ";" + alumno.Mail;
            modulo.ModificarAlumno(alumno, datos);
            Assert.IsFalse(nombreViejo.Equals(alumno.Nombre) && apellidoViejo.Equals(alumno.Apellido));
        }

        [TestMethod]
        public void ModificarAlumnoFail3Test()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "1234567-8", "np@mail.com", 1);
            modulo.Alta(alumno);
            string cedulaVieja = alumno.Cedula;
            string datos = alumno.Nombre + ";" + alumno.Apellido + ";" + "0234657-2" + ";" + alumno.Mail;
            modulo.ModificarAlumno(alumno, datos);
            Assert.IsFalse(cedulaVieja.Equals(alumno.Nombre));
        }

        [TestMethod]
        public void EliminarAlumnoInscritoEnMateriasTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            Alumno alumno   = UtilidadesPruebas.CrearAlumnoDePrueba("Maxi", "Ramirez", "3234256-7", "mr@mail.com", 9);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño Aplicaciones 1", 1);
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(ref repositorio);
            moduloAlumno.Alta(alumno);
            moduloMateria.Alta(materia);
            moduloAlumno.InscribirAlumnoEnMateria(alumno, materia);
            int antesEliminar = moduloAlumno.repositorio.Alumnos.Count;
            moduloAlumno.Baja(alumno);
            int despuesEliminar = moduloAlumno.repositorio.Alumnos.Count;
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
        public void ExisteAlumnoConMismoEmailTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre1apellido1@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsTrue(modulo.ExisteAlumnoConMismoEmail(alumno2));
        }

        [TestMethod]
        public void ExisteAlumnoConMismoEmailFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsFalse(modulo.ExisteAlumnoConMismoEmail(alumno2));
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
       
        #region ValidacionesTest
        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinNombre))]
        public void ValidarAlumnoSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinApellido))]
        public void ValidarAlumnoSinApellidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "", "0000000-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinCedula))]
        public void ValidarAlumnoSinCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionAlumnoSinEmail))]
        public void ValidarAlumnoSinEmailErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionFormatoCedulaIncorrecto))]
        public void ValidarFormatoCedulaIncorrecto()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0004h00-3", "apellido@gmail.com", 1);
            modulo.ValidarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteAlumnoConMismaCedula))]
        public void ValidarExisteAlumnoConMismaCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 2);
            modulo.Alta(alumno1);
            modulo.ValidarAlumno(alumno2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNoExisteAlumno))]
        public void ValidarNoExisteAlumno()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0004h00-3", "apellido@gmail.com", 1);
            modulo.ValidarModificarAlumno(alumno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteAlumnoConMismoEmail))]
        public void ValidarExisteAlumnoConMismoEmail()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-3", "apellido@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0111010-3", "apellido@gmail.com", 2);
            modulo.Alta(alumno1);
            modulo.ValidarAlumno(alumno2);
        }
        #endregion Validaciones test

        [TestMethod]
        public void EsFormatoCedulaAlumnoCorrectoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "0000000-8", "na@gmail.com", 4);
            Assert.IsTrue(modulo.EsFormatoCedulaAlumnoCorrecto(alumno.Cedula));
        }

        [TestMethod]
        public void EsFormatoCedulaAlumnoCorrectoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre", "Apellido", "12345-8", "na@gmail.com", 5);
            Assert.IsFalse(modulo.EsFormatoCedulaAlumnoCorrecto(alumno.Cedula));
        }

        [TestMethod]
        public void InscribirAlumnoEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(ref repositorio);
            Alumno alumno   = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño de Aplicaciones 1", 030);
            moduloAlumno.InscribirAlumnoEnMateria(alumno, materia);
            Assert.IsTrue(moduloMateria.EstaInscriptoEnLaMateria(materia, alumno));
        }

        [TestMethod]
        public void DesinscribirAlumnoEnMateriaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(ref repositorio);
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
            ModuloGestionAlumno moduloAlumno    = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño de Aplicaciones 1", 030);

            Assert.IsFalse(moduloAlumno.EstaAlumnoInscritoEnMateria(alumno, materia));

        }

        [TestMethod]
        public void EstaAlumnoInscritoEnMateriaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno moduloAlumno = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba(ref repositorio);
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Luca", "Perez", "8765432-1", "lp@mail.com", 10);
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Diseño de Aplicaciones 1", 030);
            moduloAlumno.InscribirAlumnoEnMateria(alumno, materia);

            Assert.IsTrue(moduloAlumno.EstaAlumnoInscritoEnMateria(alumno, materia));

        }

        [TestMethod]
        public void ExisteAlumnoConMismaCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-1", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsTrue(modulo.ExisteAlumnoConMismaCedula(alumno1.Cedula));
        }

        [TestMethod]
        public void ExisteAlumnoConMismaCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionAlumno modulo = UtilidadesPruebas.CrearModuloGestionAlumnosDePrueba(ref repositorio);
            Alumno alumno1 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre2", "Apellido2", "0000000-2", "nombre2apellido2@gmail.com", 2);
            modulo.Alta(alumno1);
            Assert.IsFalse(modulo.ExisteAlumnoConMismaCedula(alumno2.Cedula));
        }

    }
}

