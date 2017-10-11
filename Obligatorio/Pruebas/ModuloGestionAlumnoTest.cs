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
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Nombre1", "Apellido1", "0000000-1", "nombre1apellido1@gmail.com", 1);
            RepositorioRam repositorio = new RepositorioRam();
            ModuloGestionAlumno modulo = new ModuloGestionAlumno(repositorio);
            modulo.Alta(alumno);
            Assert.IsTrue(repositorio.Alumnos.Count == 1);
        }
    }
}
