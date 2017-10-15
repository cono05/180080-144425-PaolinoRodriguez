﻿using System;
using Persistencia;
using Dominio;
using Excepciones;

namespace Logica
{
    public class ModuloGestionAlumno : IModulo
    {
        public RepositorioRam repositorio;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ModuloGestionAlumno(ref RepositorioRam repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alta(object obj)
        {
            ValidarAlumno((Alumno)obj);
            repositorio.AgregarAlumno((Alumno)obj);
        }

        public void Baja(object obj)
        {
            // Antes de eliminar alumno, lo doy de baja en las materias que esta inscrito
            BajaDeAlumnoEnMaterias((Alumno)obj);
            repositorio.EliminarAlumno((Alumno)obj);
        }

        public void BajaDeAlumnoEnMaterias(Alumno alumno)
        {
            foreach (Materia m in repositorio.ObtenerMaterias())
            {
                if (alumno.MateriasInscripto.Contains(m))
                {
                    ModuloGestionMaterias.EliminarAlumnoDeUnaMateria(m, alumno);
                    //alumno.MateriasInscripto.Remove(m);
                }
                
            }
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public bool ExisteAlumnoConMismoNumeroEstudiante(Alumno alumno1)
        {
            bool ret = false;
            foreach (Alumno a in repositorio.ObtenerAlumnos())
            {
                if(a.NumeroDeEstudiante == alumno1.NumeroDeEstudiante)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public bool EsAlumnoSinNombre(Alumno alumno)
        {
            return string.IsNullOrEmpty(alumno.Nombre);
        }

        public bool EsAlumnoSinApellido(Alumno alumno)
        {
            return string.IsNullOrEmpty(alumno.Apellido);
        }

        public bool EsAlumnoSinCedula(Alumno alumno)
        {
            return string.IsNullOrEmpty(alumno.Cedula);
        }

        public bool EsAlumnoSinEmail(Alumno alumno)
        {
            return string.IsNullOrEmpty(alumno.Mail);
        }

        public void ValidarAlumno(Alumno alumno)
        {
            if (EsAlumnoSinNombre(alumno))
            {
                throw new ExcepcionAlumnoSinNombre();
            }
            if (EsAlumnoSinApellido(alumno))
            {
                throw new ExcepcionAlumnoSinApellido();
            }
            if(EsAlumnoSinCedula(alumno))
            {
                throw new ExcepcionAlumnoSinCedula();
            }
            if (EsAlumnoSinEmail(alumno))
            {
                throw new ExcepcionAlumnoSinEmail();
            }
            if (!EsFormatoCedulaAlumnoCorrecto(alumno))
            {
                throw new ExcepcionFormatoCedulaIncorrecto();
            }
            if (ExisteAlumnoConMismaCedula(alumno))
            {
                throw new ExcepcionExisteAlumnoConMismaCedula();
            }
        }

        public bool EsFormatoCedulaAlumnoCorrecto(Alumno alumno)
        {
            bool ret = false;
            if(alumno.Cedula.Length == 9)
            {
                string subOne   = alumno.Cedula.Substring(0, 7); 
                string subTwo   = alumno.Cedula.Substring(7, 1); 
                string subTree  = alumno.Cedula.Substring(8, 1);

                int n;
                var isNumericSubOne = int.TryParse(subOne, out n);
                if (isNumericSubOne)
                {
                    if (subTwo == "-")
                    {
                        int m;
                        var isNumericSubTree = int.TryParse(subTree, out m);
                        if (isNumericSubTree)
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        public void InscribirAlumnoEnMateria(Alumno alumno, Materia materia)
        {
            if(!EstaAlumnoInscritoEnMateria(alumno, materia))
            {
                alumno.MateriasInscripto.Add(materia);
                materia.Alumnos.Add(alumno);
            }
        }

        public bool ExisteAlumnoConMismaCedula(Alumno alumno1)
        {
            bool ret = false;
            foreach(Alumno a in repositorio.Alumnos)
            {
                if(alumno1.Cedula == a.Cedula)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public void DesincribirAlumnoEnMateria(Alumno alumno, Materia materia)
        {
            if(EstaAlumnoInscritoEnMateria(alumno, materia))
            {
                alumno.MateriasInscripto.Remove(materia);
                materia.Alumnos.Remove(alumno);
            }
        }

        public bool EstaAlumnoInscritoEnMateria(Alumno alumno, Materia materia)
        {
            return alumno.MateriasInscripto.Contains(materia);
        }
    }
}