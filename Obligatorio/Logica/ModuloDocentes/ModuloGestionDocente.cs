using System;
using Persistencia;
using Dominio;

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

        public bool ExisteDocenteConMismaCedula(Docente docente)
        {
            bool ret = false;
            foreach(Docente d in repositorio.ObtenerDocentes())
            {
                if(d.Cedula == docente.Cedula)
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

        public bool EsFormatoCedulaDocenteCorrecto(Docente docente)
        {
            bool ret = false;
            if (docente.Cedula.Length == 9)
            {
                string subOne   = docente.Cedula.Substring(0, 7);
                string subTwo   = docente.Cedula.Substring(7, 1);
                string subTree  = docente.Cedula.Substring(8, 1);

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
    }
}