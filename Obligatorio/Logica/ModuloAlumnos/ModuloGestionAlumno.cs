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
            BajaDeAlumnoEnMaterias((Alumno)obj);
            repositorio.EliminarAlumno((Alumno)obj);
            
        }

        public void ValidarAlumno(Alumno alumno)
        {
            if (EsAlumnoSinNombre(alumno))
                throw new ExcepcionAlumnoSinNombre();
            if (EsAlumnoSinApellido(alumno))
                throw new ExcepcionAlumnoSinApellido();
            if (EsAlumnoSinCedula(alumno))
                throw new ExcepcionAlumnoSinCedula();
            if (EsAlumnoSinEmail(alumno))
                throw new ExcepcionAlumnoSinEmail();
            if (!EsFormatoCedulaAlumnoCorrecto(alumno.Cedula))
                throw new ExcepcionFormatoCedulaIncorrecto();
            if (ExisteAlumnoConMismaCedula(alumno.Cedula))
                throw new ExcepcionExisteAlumnoConMismaCedula();
            if (ExisteAlumnoConMismoEmail(alumno))
                throw new ExcepcionExisteAlumnoConMismoEmail();
        }

        public void ValidarModificarAlumno(Alumno alumnoOriginal, Alumno alumnoNuevosDatos)
        {
            if (EsAlumnoSinNombre(alumnoNuevosDatos))
                throw new ExcepcionAlumnoSinNombre();
            if (EsAlumnoSinApellido(alumnoNuevosDatos))
                throw new ExcepcionAlumnoSinApellido();
            if (EsAlumnoSinCedula(alumnoNuevosDatos))
                throw new ExcepcionAlumnoSinCedula();
            if (EsAlumnoSinEmail(alumnoNuevosDatos))
                throw new ExcepcionAlumnoSinEmail();
            if (!EsFormatoCedulaAlumnoCorrecto(alumnoNuevosDatos.Cedula))
                throw new ExcepcionFormatoCedulaIncorrecto();
            if (alumnoNuevosDatos.Mail != alumnoOriginal.Mail && ExisteAlumnoConMismoEmail(alumnoNuevosDatos))
                throw new ExcepcionExisteAlumnoConMismoEmail();
            if (alumnoNuevosDatos.Cedula != alumnoOriginal.Cedula && ExisteAlumnoConMismaCedula(alumnoNuevosDatos.Cedula))
                throw new ExcepcionExisteAlumnoConMismaCedula();
        }

        public void BajaDeAlumnoEnMaterias(Alumno alumno)
        {
            foreach (Materia m in repositorio.ObtenerMaterias())
            {
                if (alumno.MateriasInscripto.Contains(m))
                {
                    m.Alumnos.Remove(alumno);
                    alumno.MateriasInscripto.Remove(m);
                }
            }
        }

        public void ModificarAlumno(ref Alumno alumnoOrignal, Alumno alumnoNuevosDatos)
        {
            ValidarModificarAlumno(alumnoOrignal, alumnoNuevosDatos);
            alumnoOrignal.Nombre    = alumnoNuevosDatos.Nombre;
            alumnoOrignal.Apellido  = alumnoNuevosDatos.Apellido;
            alumnoOrignal.Cedula    = alumnoNuevosDatos.Cedula;
            alumnoOrignal.Mail      = alumnoNuevosDatos.Mail;
        }

        public ICollection<Alumno> ObtenerAlumnos()
        {
            return repositorio.ObtenerAlumnos();
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
                    break;
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

        public bool ExisteAlumnoConMismoEmail(Alumno alumno)
        {
            bool ret = false;
            foreach(Alumno a in repositorio.Alumnos)
            {
                if(a.Mail == alumno.Mail)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
    }
}