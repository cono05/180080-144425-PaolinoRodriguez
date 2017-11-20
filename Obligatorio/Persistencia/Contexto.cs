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
        public DbSet<Actividad> Actividades { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // PK -- Primary key de alumno es el Id
            modelBuilder.Entity<Alumno>()
                .HasKey(alumno => alumno.Id);

            // PK -- Primary key de docente es el Id
            modelBuilder.Entity<Docente>()
                .HasKey(docente => docente.Id);

            // PK -- Primary key de materia es el codigo
            modelBuilder.Entity<Materia>()
                .HasKey(materia => materia.Codigo);

            // PK -- Primary key de camioneta es la chapa
            modelBuilder.Entity<Camioneta>()
                .HasKey(camioneta => camioneta.Chapa);

            // PK -- Primary key de actividad es el Id
            modelBuilder.Entity<Actividad>()
                .HasKey(actividad => actividad.Id);

            // N a N entre alumno y materia
            modelBuilder.Entity<Alumno>()
                .HasMany(alumno => alumno.MateriasInscripto)
                .WithMany(materia => materia.Alumnos)
                .Map(m =>
                {
                    m.ToTable("Alumno_Materia");
                    m.MapLeftKey("AlumnoId");
                    m.MapRightKey("MateriaCodigo");
                });
            //A partir de .map es opcional. Es para el nombre del mappeo de las relaciones

            // N a N entre docente y materia
            modelBuilder.Entity<Docente>()
                .HasMany(docente => docente.MateriasQueDicta)
                .WithMany(materia => materia.Docentes)
                .Map(m =>
                {
                    m.ToTable("Docente_Materia");
                    m.MapLeftKey("DocenteId");
                    m.MapRightKey("MateriaCodigo");
                });

            // N a N entre actividad y alumnos
            modelBuilder.Entity<Actividad>()
                .HasMany(actividad => actividad.Participantes)
                .WithMany(alumno => alumno.ActividadesInscripto)
                .Map(m =>
                {
                    m.ToTable("Actividad_Alumno");
                    m.MapLeftKey("ActividadId");
                    m.MapRightKey("AlumnoId");
                });
        }

    }
}
