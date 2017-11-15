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
        public DbSet<Alumno>    Alumnos     { get; set; }
        public DbSet<Docente>   Docentes    { get; set; }
        public DbSet<Materia>   Materias    { get; set; }
        public DbSet<Camioneta> Camionetas  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Alumno>()
                .HasKey(alumno => alumno.Id);

            modelBuilder.Entity<Materia>()
                .HasKey(materia => materia.Id);

            modelBuilder.Entity<Docente>()
                .HasKey(docente => docente.Id);

            modelBuilder.Entity<Camioneta>()
                .HasKey(camioneta => camioneta.Id);


            // N a N entre alumno y materia
            modelBuilder.Entity<Alumno>()
                .HasMany(alumno => alumno.MateriasInscripto)
                .WithMany(materia => materia.Alumnos)
                .Map(m =>
                {
                    m.ToTable("Alumno_Materia");
                    m.MapLeftKey("AlumnoId");
                    m.MapRightKey("MateriaId");
                });
            //A partir de .map es opcional. Es para el nombre del mappeo de las relaciones

            modelBuilder.Entity<Docente>()
                .HasMany(docente => docente.MateriasQueDicta)
                .WithMany(materia => materia.Docentes)
                .Map(m =>
                {
                    m.ToTable("Docente_Materia");
                    m.MapLeftKey("DocenteId");
                    m.MapRightKey("MateriaId");
                });
        }
    }
}
