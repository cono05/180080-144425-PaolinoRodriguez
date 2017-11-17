using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class Contexto : DbContext
    {
        public DbSet<Alumno>    Alumnos { get; set; }
        public DbSet<Docente>   Docentes { get; set; }
        public DbSet<Materia>   Materias { get; set; }
        public DbSet<Camioneta> Camionetas { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}
