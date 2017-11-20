using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Persistencia;
using Logica;
using Excepciones;

namespace Pruebas
{
    [TestClass]
    public class ModuloGestionDocenteTest
    {
        [TestMethod]
        public void GetNombreModuloGestionDocenteTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente moduloDocente= UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            moduloDocente.Nombre = "moduloDocente";
            Assert.AreEqual("moduloDocente", moduloDocente.Nombre);
        }

        [TestMethod]
        public void GetDescripcionModuloGestionDocenteTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            moduloDocente.Descripcion = "moduloDescripcion";
            Assert.AreEqual("moduloDescripcion", moduloDocente.Descripcion);
        }

        [TestMethod]
        public void AgregarDocenteTest()
        {
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            modulo.Alta(docente);
            Assert.IsTrue(repositorio.Docentes.Count == 1);
        }

        [TestMethod]
        public void EliminarDocenteTest()
        {
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            modulo.Alta(docente);
            int antesEliminar = repositorio.Docentes.Count;
            modulo.Baja(docente);
            int despuesEliminar = repositorio.Docentes.Count;
            Assert.IsTrue(antesEliminar == despuesEliminar + 1);
        }


        [TestMethod]
        public void ModificarDocenteTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docenteOriginal = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docenteNuevosDatos = UtilidadesPruebas.CrearDocenteDePrueba("NombreNuevo", "ApellidoNuevo", "1234567-8");
            modulo.Alta(docenteOriginal);
            string nombreOriginal = docenteOriginal.Nombre;
            string apellidoOriginal = docenteOriginal.Apellido;
            modulo.ModificarDocente(ref docenteOriginal, docenteNuevosDatos);
            string nombreActualizado = docenteOriginal.Nombre;
            string apellidoActualizado = docenteOriginal.Apellido;
            Assert.IsTrue(!(nombreOriginal.Equals(nombreActualizado) && !(apellidoOriginal.Equals(apellidoActualizado))));
        }

        [TestMethod]
        public void InscribirDocenteTest()
        {
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Carlitos", "Roxlo", "1234567-8");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Algoritmos", 1);
            moduloDocente.InscribirDocenteEnMateria(docente, materia);
            Assert.IsTrue(moduloDocente.EstaInscritoEnLaMateria(docente, materia));
        }

        [TestMethod]
        public void DesinscribirDocenteTest()
        {
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionDocente moduloDocente = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            ModuloGestionMaterias moduloMateria = UtilidadesPruebas.CrearModuloGestionMateriasDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Carlitos", "Roxlo", "1234567-8");
            Materia materia = UtilidadesPruebas.CrearMateriaDePueba("Algoritmos", 1);
            moduloDocente.InscribirDocenteEnMateria(docente, materia);
            bool esInscrito1 = moduloDocente.EstaInscritoEnLaMateria(docente, materia);
            moduloDocente.DesinscribirDocenteEnMateria(docente, materia);
            bool esInscrito2 = moduloDocente.EstaInscritoEnLaMateria(docente, materia);
            Assert.IsTrue(esInscrito1 && !esInscrito2);
        }

        [TestMethod]
        public void ExisteDocenteConMismaCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-2");
            modulo.Alta(docente1);
            Assert.IsTrue(modulo.ExisteDocenteConMismaCedula(docente1.Cedula));
        }

        [TestMethod]
        public void ExisteDocenteConMismaCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-2");
            modulo.Alta(docente1);
            Assert.IsFalse(modulo.ExisteDocenteConMismaCedula(docente2.Cedula));
        }

        [TestMethod]
        public void EsDocenteSinNombreTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("", "Apellido", "0000000-1");
            Assert.IsTrue(modulo.EsDocenteSinNombre(docente));
        }

        [TestMethod]
        public void EsDocenteSinNombreFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinNombre(docente));
        }

        [TestMethod]
        public void EsDocenteSinApellidoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "", "0000000-1");
            Assert.IsTrue(modulo.EsDocenteSinApellido(docente));
        }

        [TestMethod]
        public void EsDocenteSinApellidoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinApellido(docente));
        }

        [TestMethod]
        public void EsDocenteSinCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "");
            Assert.IsTrue(modulo.EsDocenteSinCedula(docente));
        }

        [TestMethod]
        public void EsDocenteSinCedulaFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "0000000-1");
            Assert.IsFalse(modulo.EsDocenteSinCedula(docente));
        }

        [TestMethod]
        public void EsFormatoCedulaDocenteCorrectoTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Assert.IsTrue(modulo.EsFormatoCedulaDocenteCorrecto(docente.Cedula));
        }

        [TestMethod]
        public void EsFormatoCedulaDocenteCorrectoFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234-67-8");
            Assert.IsFalse(modulo.EsFormatoCedulaDocenteCorrecto(docente.Cedula));
        }

        #region Validaciones
        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinNombre))]
        public void ValidarDocenteSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("", "Apellido", "1234567-8");
            modulo.ValidarAlta(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinApellido))]
        public void ValidarDocenteSinApellidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "", "1234567-8");
            modulo.ValidarAlta(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinCedula))]
        public void ValidarDocenteSinCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "");
            modulo.ValidarAlta(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionFormatoCedulaIncorrecto))]
        public void ValidarDocenteFormatoCedulaIncorrectoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "123-4");
            modulo.ValidarAlta(docente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteDocenteConMismaCedula))]
        public void ValidarDocenteConCedulaExistenteErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre2", "Apellido2", "1234567-8");
            modulo.Alta(docente1);
            modulo.ValidarAlta(docente2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinNombre))]
        public void ValidarModificarDocenteSinNombreErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("", "Apellido", "1234567-8");
            modulo.ValidarModificarDocente(docente1, docente2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinApellido))]
        public void ValidarModificarDocenteSinApellidoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "", "1234567-8");
            modulo.ValidarModificarDocente(docente1, docente2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDocenteSinCedula))]
        public void ValidarModificarDocenteSinCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "");
            modulo.ValidarModificarDocente(docente1, docente2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionFormatoCedulaIncorrecto))]
        public void ValidarModificarDocenteFormatoCedulaIncorrectoErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "234");
            modulo.ValidarModificarDocente(docente1, docente2);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionExisteDocenteConMismaCedula))]
        public void ValidarModificarDocenteExisteDocenteConMismaCedulaErrorTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            modulo.Alta(docente1);
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "2456756-1");
            Docente docente3 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            modulo.ValidarModificarDocente(docente2, docente3);
        }       
        #endregion

        [TestMethod]
        public void ObtenerDocentesTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Docente docente2 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre2", "Apellido2", "1334567-8");
            modulo.Alta(docente1);
            modulo.Alta(docente2);
            Assert.IsTrue(modulo.ObtenerDocentes().Count == 2);
        }

        [TestMethod]
        public void HayDocentesRegistradosFalseTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            Assert.IsFalse(modulo.HayDocentesRegistrados());
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNoExisteDocente))]
        public void ValidarBajaErrorCedulaTest()
        {
            RepositorioRam repositorio = UtilidadesPruebas.CrearRepositorioRamDePrueba();
            ModuloGestionDocente modulo = UtilidadesPruebas.CrearModuloGestionDocentesDePrueba( repositorio);
            Docente docente1 = UtilidadesPruebas.CrearDocenteDePrueba("Nombre", "Apellido", "1234567-8");
            modulo.ValidarBaja(docente1);
        }

    }
}
