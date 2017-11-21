namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Diagnostics.CodeAnalysis;
    public partial class InitialCreate : DbMigration
    {
        [ExcludeFromCodeCoverage]
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroDeEstudiante = c.Int(nullable: false),
                        Mail = c.String(),
                        Apellido = c.String(),
                        Nombre = c.String(),
                        Cedula = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Docentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Apellido = c.String(),
                        Nombre = c.String(),
                        Cedula = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Camionetas",
                c => new
                    {
                        Chapa = c.String(nullable: false, maxLength: 128),
                        Marca = c.String(),
                        Capacidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Chapa);
            
            CreateTable(
                "dbo.Docente_Materia",
                c => new
                    {
                        DocenteId = c.Int(nullable: false),
                        MateriaCodigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DocenteId, t.MateriaCodigo })
                .ForeignKey("dbo.Docentes", t => t.DocenteId, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.MateriaCodigo, cascadeDelete: true)
                .Index(t => t.DocenteId)
                .Index(t => t.MateriaCodigo);
            
            CreateTable(
                "dbo.Alumno_Materia",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false),
                        MateriaCodigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AlumnoId, t.MateriaCodigo })
                .ForeignKey("dbo.Alumnoes", t => t.AlumnoId, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.MateriaCodigo, cascadeDelete: true)
                .Index(t => t.AlumnoId)
                .Index(t => t.MateriaCodigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno_Materia", "MateriaCodigo", "dbo.Materias");
            DropForeignKey("dbo.Alumno_Materia", "AlumnoId", "dbo.Alumnoes");
            DropForeignKey("dbo.Docente_Materia", "MateriaCodigo", "dbo.Materias");
            DropForeignKey("dbo.Docente_Materia", "DocenteId", "dbo.Docentes");
            DropIndex("dbo.Alumno_Materia", new[] { "MateriaCodigo" });
            DropIndex("dbo.Alumno_Materia", new[] { "AlumnoId" });
            DropIndex("dbo.Docente_Materia", new[] { "MateriaCodigo" });
            DropIndex("dbo.Docente_Materia", new[] { "DocenteId" });
            DropTable("dbo.Alumno_Materia");
            DropTable("dbo.Docente_Materia");
            DropTable("dbo.Camionetas");
            DropTable("dbo.Docentes");
            DropTable("dbo.Materias");
            DropTable("dbo.Alumnoes");
        }
    }
}
