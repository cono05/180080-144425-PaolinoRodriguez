using System;
using Persistencia;

namespace Logica
{
    public class ModuloGestionAlumno : IModulo
    {
        private RepositorioRam repositorio;

        public ModuloGestionAlumno(RepositorioRam repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alta(object obj)
        {
            throw new NotImplementedException();
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