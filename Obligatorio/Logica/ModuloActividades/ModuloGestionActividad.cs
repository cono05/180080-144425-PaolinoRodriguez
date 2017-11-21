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
            repositorio.EliminarActividad((Actividad)obj);
        }

        public ICollection<Actividad> ObtenerActividades()
        {
            return repositorio.ObtenerActividades();
        }

        public void ModificarActividad(ref Actividad actividadOriginal, Actividad actividadNuevosDatos)
        {
            //Validar
            repositorio.ModificarActividad(actividadOriginal, actividadNuevosDatos);
        }

        public void AgregarParticipanteEnActividad(Actividad actividad, Alumno alumno)
        {
            //Validar que ya no este
            repositorio.AgregarParticipanteEnActividad(actividad, alumno);
        }

        public Actividad ObtenerActividadPorId(int id)
        {
            return repositorio.ObtenerActividadPorId(id);
        }

        public void EliminarParticipanteEnActividad(Actividad actividad, Alumno alumno)
        {
            //Validar que existe
            repositorio.EliminarParticipanteEnActividad(actividad, alumno);
        }

        #region Validaciones
        public bool EsActividadSinNombre(Actividad actividad)
        {
            return string.IsNullOrEmpty(actividad.Nombre);
        }

        public bool EsActividadSinFecha(Actividad actividad)
        {
            return actividad.Fecha.CompareTo(DateTime.MinValue) == 0;
        }

        public bool EsActividadSinCosto(Actividad actividad)
        {
            return actividad.Costo == 0;
        }


        #endregion
    }
}