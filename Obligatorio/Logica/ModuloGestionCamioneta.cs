using System;
using Persistencia;

namespace Logica
{
    public class ModuloGestionCamioneta : IModulo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        private RepositorioRam repositorio;

        public ModuloGestionCamioneta(ref RepositorioRam repositorio)
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