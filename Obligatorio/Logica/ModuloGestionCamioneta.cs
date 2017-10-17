using System;
using System.Collections.Generic;
using Dominio;
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
            repositorio.AgregarCamioneta((Camioneta)obj);
        }

        public void Baja(object obj)
        {
            repositorio.EliminarCamioneta((Camioneta)obj);
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public ICollection<Camioneta> ObtenerCamionetas()
        {
            return repositorio.ObtenerCamionetas();
        }

        public bool ExisteCamioneta(Camioneta camioneta)
        {
            bool retorno = false;
            retorno = ObtenerCamionetas().Contains(camioneta);
            return retorno;
        }

        public bool EsCamionetaSinChapa(Camioneta camioneta)
        {
            throw new NotImplementedException();
        }
    }
}