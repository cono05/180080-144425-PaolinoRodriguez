﻿using System.Collections.Generic;

namespace Dominio
{
    public class Alumno : Persona
    {
        public int NumeroDeEstudiante { get; set; }
        public string Cedula { get; set; }
        public string Mail { get; set; }
        public ICollection<Materia> MateriasInscripto { get; set; }

        public Alumno()
        {
            this.Cedula = string.Empty;
            this.MateriasInscripto = new List<Materia>();
        }
        public static Alumno CrearAlumno()
        {
            Alumno alumno = new Alumno();
            return alumno;
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj != null && this.GetType() == obj.GetType())
            {
                Alumno alumno = (Alumno)obj;
                equals = alumno.Cedula.Equals(Cedula);
            }
            return equals;
        }
    }
}