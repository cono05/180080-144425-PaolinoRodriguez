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
    }
}