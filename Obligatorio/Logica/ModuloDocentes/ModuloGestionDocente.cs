using System;
using Persistencia;
using Dominio;
using Excepciones;
using System.Collections.Generic;

namespace Logica
{
    public class ModuloGestionDocente : IModulo
    {
        private IRepositorio repositorio;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ModuloGestionDocente(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alta(object obj)
        {
            ValidarAlta((Docente)obj);
            repositorio.AgregarDocente((Docente)obj);
        }

        public void Baja(object obj)
        {
            ValidarBaja((Docente)obj);
            repositorio.EliminarDocente((Docente)obj);
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public void ValidarAlta(Docente docente)
        {
            if (ExisteDocenteConMismaCedula(docente.Cedula))
                throw new ExcepcionExisteDocenteConMismaCedula();
            if (EsDocenteSinNombre(docente))
                throw new ExcepcionDocenteSinNombre();
            if (EsDocenteSinApellido(docente))
                throw new ExcepcionDocenteSinApellido();
            if (EsDocenteSinCedula(docente))
                throw new ExcepcionDocenteSinCedula();
            if (!EsFormatoCedulaDocenteCorrecto(docente.Cedula))
                throw new ExcepcionFormatoCedulaIncorrecto();
        }

        public void ModificarDocente(ref Docente docenteOriginal, Docente docenteNuevosDatos)
        {
            ValidarModificarDocente(docenteOriginal, docenteNuevosDatos);
            repositorio.ModificarDocente(docenteOriginal, docenteNuevosDatos);
        }

        public void ValidarModificarDocente(Docente docenteOriginal, Docente docenteNuevosDatos)
        {
            if (docenteOriginal.Cedula != docenteNuevosDatos.Cedula && ExisteDocenteConMismaCedula(docenteNuevosDatos.Cedula))
                throw new ExcepcionExisteDocenteConMismaCedula();
            if (EsDocenteSinNombre(docenteNuevosDatos))
                throw new ExcepcionDocenteSinNombre();
            if (EsDocenteSinApellido(docenteNuevosDatos))
                throw new ExcepcionDocenteSinApellido();
            if (EsDocenteSinCedula(docenteNuevosDatos))
                throw new ExcepcionDocenteSinCedula();
            if (!EsFormatoCedulaDocenteCorrecto(docenteNuevosDatos.Cedula))
                throw new ExcepcionFormatoCedulaIncorrecto();
        }

        public void ValidarBaja(Docente docente)
        {
            if (!ExisteDocenteConMismaCedula(docente.Cedula))
                throw new ExcepcionNoExisteDocente();
        }

        public bool ExisteDocenteConMismaCedula(string cedula)
        {
            bool ret = false;
            foreach(Docente d in repositorio.ObtenerDocentes())
            {
                if(d.Cedula == cedula)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public bool EsDocenteSinNombre(Docente docente)
        {
            return string.IsNullOrEmpty(docente.Nombre);
        }

        public bool EsDocenteSinApellido(Docente docente)
        {
            return string.IsNullOrEmpty(docente.Apellido);
        }

        public bool EsDocenteSinCedula(Docente docente)
        {
            return string.IsNullOrEmpty(docente.Cedula);
        }

        public bool EstaInscritoEnLaMateria(Docente docente, Materia materia)
        {
            ICollection<Docente> listaDocentes = repositorio.ObtenerDocentesDeLaMateria(materia);
            return listaDocentes.Contains(docente);
        }

        public void InscribirDocenteEnMateria(Docente docente, Materia materia)
        {
            if (!EstaInscritoEnLaMateria(docente, materia))
            {
                repositorio.AgregarDocenteEnMateria(materia, docente);
            }
        }

        public void DesinscribirDocenteEnMateria(Docente docente, Materia materia)
        {
            if (EstaInscritoEnLaMateria(docente, materia))
            {
                repositorio.EliminarDocenteEnMateria(materia, docente);
            }
        }

        public bool EsFormatoCedulaDocenteCorrecto(string cedula)
        {
            bool ret = false;
            if (cedula.Length == 9)
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

        public ICollection<Docente> ObtenerDocentes()
        {
            return repositorio.ObtenerDocentes();
        }

        public bool HayDocentesRegistrados()
        {
            return ObtenerDocentes().Count > 0;
        }
        /*TODO: Docente y Alumno pueden tener la misma cedula. Cambiar */
    }
}