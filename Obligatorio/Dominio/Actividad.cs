using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
        public virtual ICollection<Alumno> Participantes { get; set; }

        private Actividad()
        {
            Participantes = new List<Alumno>();
        }

        public static Actividad CrearActividad()
        {
            Actividad actividad = new Actividad();
            return actividad;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && this.GetType() == obj.GetType())
            {
                Actividad actividad = (Actividad)obj;
                equals = actividad.Id.Equals(Id);
            }
            return equals;
        }

        public override string ToString()
        {
            return "Actividad: " + Nombre + " Fecha:" + Fecha;
        }
    }
}