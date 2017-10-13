using System;
using Persistencia;
using Dominio;

namespace Logica
{
    public class ModuloGestionDocente : IModulo
    {
        private RepositorioRam repositorio;

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
    }
}