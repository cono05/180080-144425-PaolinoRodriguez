using System;
using System.Collections.Generic;
using Dominio;
using Persistencia;
using Excepciones;

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
            ValidarAlta((Camioneta)obj);
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
            bool retorno = false;
            retorno = string.IsNullOrEmpty(camioneta.Chapa);
            return retorno;

        }

        public bool EsCamionetaSinMarca(Camioneta camioneta)
        {
            bool retorno = false;
            retorno = string.IsNullOrEmpty(camioneta.Marca);
            return retorno;
        }

        public void ValidarAlta(Camioneta camioneta)
        {
            if (ExisteCamioneta(camioneta))
                throw new ExcepcionExisteCamionetaConMismaChapa();
            if (EsCamionetaSinChapa(camioneta))
                throw new ExcepcionCamionetaSinChapa();
            if (EsCamionetaSinMarca(camioneta))
                throw new ExcepcionCamionetaSinMarca();
        }

        public bool TieneCapacidadNoValida(Camioneta camioneta)
        {
            bool retorno = false;
            retorno = camioneta.Capacidad <= 0 || camioneta.Capacidad > 40;
            return retorno;
        }
    }
}