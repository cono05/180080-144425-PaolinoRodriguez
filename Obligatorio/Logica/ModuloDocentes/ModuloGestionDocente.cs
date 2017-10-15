using System;
using Persistencia;
using Dominio;
using Excepciones;

namespace Logica
{
    public class ModuloGestionDocente : IModulo
    {
        private RepositorioRam repositorio;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ModuloGestionDocente(RepositorioRam repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alta(object obj)
        {
            repositorio.AgregarDocente((Docente)obj);
        }

        public void Baja(object obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
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

        public void ValidarDocente(Docente docente)
        {
            if (EsDocenteSinNombre(docente))
            {
                throw new ExcepcionDocenteSinNombre();
            }
            if (EsDocenteSinApellido(docente))
            {
                throw new ExcepcionDocenteSinApellido();
            }
            if (EsDocenteSinCedula(docente))
            {
                throw new ExcepcionDocenteSinCedula();
            }
            if (!EsFormatoCedulaDocenteCorrecto(docente.Cedula))
            {
                throw new ExcepcionFormatoCedulaIncorrecto();
            }
            if (ExisteDocenteConMismaCedula(docente.Cedula))
            {
                throw new ExcepcionExisteDocenteConMismaCedula();
            }
            
        }
        /*TODO: Docente y Alumno pueden tener la misma cedula. Cambiar */
    }
}