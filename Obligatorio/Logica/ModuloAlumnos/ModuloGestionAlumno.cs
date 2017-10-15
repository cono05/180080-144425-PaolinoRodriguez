using System;
using Persistencia;
using Dominio;
using Excepciones;
using System.Collections.Generic;

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
            ValidarBajaAlumno((Alumno)obj);
            BajaDeAlumnoEnMaterias((Alumno)obj);
            repositorio.EliminarAlumno((Alumno)obj);
            
        }

        public void ValidarBajaAlumno(Alumno alumno)
        {
            if (!ExisteAlumnoConMismaCedula(alumno.Cedula))
                throw new ExcepcionNoExisteAlumno();
        }

        public void BajaDeAlumnoEnMaterias(Alumno alumno)
        {
            foreach (Materia m in repositorio.ObtenerMaterias())
            {
                if (alumno.MateriasInscripto.Contains(m))
                {
                    ModuloGestionMaterias.EliminarAlumnoDeUnaMateria(m, alumno);
                }
            }
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public void ModificarAlumno(Alumno alumno, string cambios)
        {
            ValidarBajaAlumno(alumno);
            // Respetar orden: Nombre;Apellido;Cedula;Email
            string[] nuevosDatos = cambios.Split(';');
            string nuevoNombre      = nuevosDatos[0];
            string nuevoApellido    = nuevosDatos[1];
            string nuevaCedula      = nuevosDatos[2];
            string nuevoEmail       = nuevosDatos[3];

            alumno.Nombre = nuevoNombre;
            alumno.Apellido = nuevoApellido;
            if((alumno.Cedula != nuevaCedula) && ValidarCedula(nuevaCedula))
                alumno.Cedula = nuevaCedula;
            alumno.Mail = nuevoEmail;
        }

        private bool ValidarCedula(string cedulaParaValidar)
        {
            return EsFormatoCedulaAlumnoCorrecto(cedulaParaValidar) && !ExisteAlumnoConMismaCedula(cedulaParaValidar);
        }

        #region Control de atributos
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
        #endregion

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
            if (EsAlumnoSinCedula(alumno))
            {
                throw new ExcepcionAlumnoSinCedula();
            }
            if (EsAlumnoSinEmail(alumno))
            {
                throw new ExcepcionAlumnoSinEmail();
            }
            if (!EsFormatoCedulaAlumnoCorrecto(alumno.Cedula))
            {
                throw new ExcepcionFormatoCedulaIncorrecto();
            }
            if (ExisteAlumnoConMismaCedula(alumno.Cedula))
            {
                throw new ExcepcionExisteAlumnoConMismaCedula();
            }
        }

        public bool EsFormatoCedulaAlumnoCorrecto(string cedula)
        {
            bool ret = false;
            if(cedula.Length == 9)
            {
                string subOne   = cedula.Substring(0, 7); 
                string subTwo   = cedula.Substring(7, 1); 
                string subTree  = cedula.Substring(8, 1);

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

        public bool ExisteAlumnoConMismaCedula(string cedula)
        {
            bool ret = false;
            foreach(Alumno a in repositorio.Alumnos)
            {
                if(cedula == a.Cedula)
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