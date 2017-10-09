using System;
using Dominio;
using Persistencia;
namespace Logica
{
    public class ModuloGestionMaterias: IModulo
    {
        public IRepositorio repositorio { get; set; }

        public ModuloGestionMaterias(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        
        public void Alta(object o)
        {
            this.repositorio.AgregarMateria((Materia)o);
        }

        public void Baja(object o)
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }

        public bool ExisteMateriaConMismoNombre(Materia materia)
        {
            bool retorno = false;
            foreach (Materia mat in repositorio.ObtenerMaterias())
            {
                if (mat.Equals(materia))
                    return true;
            }
            return retorno;
        }
    }
}