using System;
using Dominio;
using Persistencia;
using Excepciones;
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

        public void ValidarMateria(Materia materia)
        {
            if (ExisteMateriaConMismoNombre(materia))
                throw new ExcepcionExisteMateriaConMismoNombre();
            if (EsMateriaSinNombre(materia))
                throw new ExcepcionMateriaSinNombre();
            if (ExisteMateriaConMismoCodigo(materia))
                throw new ExcepcionMateriaCodigoRepetido();
        }

        public bool EsMateriaSinNombre(Materia materia)
        {
            return string.IsNullOrEmpty(materia.Nombre);
        }

        public bool ExisteMateriaConMismoCodigo(Materia materia)
        {
            bool retorno = false;
            foreach (Materia m in repositorio.ObtenerMaterias())
            {                
                if (materia.Codigo.Equals(materia.Codigo))
                    return true;
            }
            return retorno;
        }
    }
}