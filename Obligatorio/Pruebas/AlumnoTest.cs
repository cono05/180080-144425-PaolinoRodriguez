﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;

namespace Pruebas
{
    [TestClass]
    public class AlumnoTest
    {
        [TestMethod]
        public void CrearAlumnoVacioTest()
        {
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("" , "" , "" , "" , 0);
            Assert.IsTrue(string.IsNullOrEmpty(alumno.Apellido));
            
        }

        [TestMethod]
        public void EqualsOkTest()
        {
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Perez", "12345678", "j@gmail.com",111111);
            Alumno alumno2 = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Perez", "12345678", "j2@gmail.com", 111111);
            alumno2.NumeroDeEstudiante = alumno.NumeroDeEstudiante;
            Assert.IsTrue(alumno.Equals(alumno2));
        }

        [TestMethod]
        public void ToStringTest()
        {
            Alumno alumno = UtilidadesPruebas.CrearAlumnoDePrueba("Jose", "Diaz", "1233456-7", "jj@g.com", 11);
            string esperado = "Jose Diaz" + " (" + alumno.NumeroDeEstudiante + ")";
            Assert.AreEqual(esperado, alumno.ToString());
        }

    }
}
