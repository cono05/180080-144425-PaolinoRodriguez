﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Logica;
using Persistencia;
namespace Pruebas
{
    class UtilidadesPruebas
    {
        public static RepositorioRam CrearRepositorioRamDePrueba()
        {
            RepositorioRam repositorio = new RepositorioRam();
            return repositorio;
        }
        public static Materia CrearMateriaDePueba(string nombre, int codigo)
        {
            Materia materia = Materia.CrearMateria();
            materia.Nombre = nombre;
            //materia.Codigo = codigo;
            return materia;
        }

        public static Alumno CrearAlumnoDePrueba(string nombre, string apellido, string cedula, string mail, int numeroDeEstudiante)
        {
            Alumno alumno = Alumno.CrearAlumno();
            alumno.Nombre = nombre;
            alumno.Apellido = apellido;
            alumno.Cedula = cedula;
            alumno.Mail = mail;
            alumno.NumeroDeEstudiante = numeroDeEstudiante;
            return alumno;
        }

        public static Docente CrearDocenteDePrueba(string nombre, string apellido, string cedula)
        {
            Docente docente = Docente.CrearDocente();
            docente.Nombre = nombre;
            docente.Apellido = apellido;
            docente.Cedula = cedula;
            return docente;
        }

        public static ModuloGestionMaterias CrearModuloGestionMateriasDePrueba(ref RepositorioRam repositorio)
        {
            ModuloGestionMaterias moduloGestionMaterias = new ModuloGestionMaterias(ref repositorio);
            //ModuloGestionMaterias moduloGestionMaterias = ModuloGestionMaterias.ObtenerInstancia(ref repositorio);
            return moduloGestionMaterias;
        }

        public static ModuloGestionAlumno CrearModuloGestionAlumnosDePrueba(ref RepositorioRam repositorio)
        {
            ModuloGestionAlumno moduloGestionAlumnos = new ModuloGestionAlumno(ref repositorio);
            return moduloGestionAlumnos;
        }

        public static ModuloGestionDocente CrearModuloGestionDocentesDePrueba(ref RepositorioRam repositorio)
        {
            ModuloGestionDocente moduloGestionDocentes = new ModuloGestionDocente(repositorio);
            return moduloGestionDocentes;
        }


    }
}
