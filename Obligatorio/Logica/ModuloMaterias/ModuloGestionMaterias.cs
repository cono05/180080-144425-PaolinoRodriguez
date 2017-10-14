using System;
using Dominio;
using Persistencia;
using Excepciones;
using System.Collections.Generic;

namespace Logica
{
    public class ModuloGestionMaterias: IModulo
    {
        private IRepositorio repositorio;
        //private static ModuloGestionMaterias instancia;
        public ModuloGestionMaterias(ref RepositorioRam repositorio)
        {
            this.repositorio = repositorio;
        }

        //public static ModuloGestionMaterias ObtenerInstancia(ref RepositorioRam repositorio)
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new ModuloGestionMaterias(ref repositorio);
        //    }
        //    return instancia;
        //}

        public void Alta(object obj)
        {
            ValidarAltaMateria((Materia)obj);
            repositorio.AgregarMateria((Materia)obj);
        }

        public void Baja(object obj)
        {
            ValidarBajaMateria((Materia)obj);
            repositorio.EliminarMateria((Materia)obj);
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

        public ICollection<Materia> ObtenerMaterias()
        {
            return repositorio.ObtenerMaterias();
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
                if (m.Codigo.Equals(materia.Codigo))
                    return true;
            }
            return retorno;
        }

        public void AgregarAlumnoEnMateria(Materia materia, Alumno alumno)
        {
            materia.Alumnos.Add(alumno); 
        }

        public void ValidarAltaMateria(Materia materia)
        {
            if (ExisteMateriaConMismoNombre(materia))
                throw new ExcepcionExisteMateriaConMismoNombre();
            if (EsMateriaSinNombre(materia))
                throw new ExcepcionMateriaSinNombre();
            if (ExisteMateriaConMismoCodigo(materia))
                throw new ExcepcionMateriaCodigoRepetido();
        }

        public bool EstaInscriptoEnLaMateria(Materia materia, Alumno alumno)
        {
            bool retorno = false;
            foreach (Alumno a in materia.Alumnos)
            {
                if (TienenMismoNumeroEstudiante(a, alumno))
                    return true;
            }
            return retorno;
        }

        public bool TienenMismoNumeroEstudiante(Alumno alumno, Alumno alumno2)
        {
            return alumno.NumeroDeEstudiante == alumno2.NumeroDeEstudiante;
        }

        private void ValidarBajaMateria(Materia materia)
        {
            if (!ExisteMateriaConMismoCodigo(materia))
                throw new ExcepcionNoExisteMateriaConEseCodigo();
        }
    }
}