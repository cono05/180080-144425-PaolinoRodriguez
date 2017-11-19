using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;


namespace Pruebas
{
    class UtilidadesBD
    {
        public static void VaciarTablas()
        {
            //Database.SetInitializer<Contexto>(null);
            using (var contexto = new Contexto())
            {
                var alumnos = (from alumno in contexto.Alumnos select alumno);
                foreach (Alumno alumno in alumnos)
                {

                    contexto.Alumnos.Remove(alumno);
                }

                var docentes = (from docente in contexto.Docentes
                                select docente);
                foreach (Docente docente in docentes)
                {
                    contexto.Docentes.Remove(docente);
                }
                contexto.SaveChanges();
            }
        }
    }
}
