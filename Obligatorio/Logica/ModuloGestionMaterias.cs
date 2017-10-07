using System;
using Dominio;
using Persistencia;
namespace Logica
{
    public class ModuloGestionMaterias: IModulo
    {
        public IRepositorio repositorio;

        public ModuloGestionMaterias(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        
        public void Alta(object o)
        {
            throw new NotImplementedException();
        }

        public void Baja(object o)
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}