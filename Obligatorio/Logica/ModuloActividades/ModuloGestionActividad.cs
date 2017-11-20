using System;
using Persistencia;
using Excepciones;
using System.Collections.Generic;

namespace Logica
{
    public class ModuloGestionActividad : IModulo
    {
        private IRepositorio repositorio;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ModuloGestionActividad(IRepositorio repositorio)
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
    }
}