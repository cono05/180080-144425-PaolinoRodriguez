﻿using System;
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
        public ModuloGestionMaterias(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        //public static ModuloGestionMaterias ObtenerInstancia(IRepositorio repositorio)
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new ModuloGestionMaterias(repositorio); 
        //    }
        //    return instancia;
        //}
        
        public void Alta(object obj)
        {
            ValidarMateria((Materia)obj);
            this.repositorio.AgregarMateria((Materia)obj);
        }

        public void Baja(object obj)
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

        public void ValidarMateria(Materia materia)
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
    }
}