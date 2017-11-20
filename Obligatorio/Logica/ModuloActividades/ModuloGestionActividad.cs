using System;
using Persistencia;
using Excepciones;
using System.Collections.Generic;
using Dominio;

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
            repositorio.AgregarActividad((Actividad)obj);
        }

        public void Baja(object obj)
        {
            throw new NotImplementedException();
        }

        public ICollection<Actividad> ObtenerActividades()
        {
            return repositorio.ObtenerActividades();
        }

    }
}