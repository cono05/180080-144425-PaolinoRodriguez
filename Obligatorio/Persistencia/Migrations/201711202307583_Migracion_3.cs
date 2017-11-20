namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracion_3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actividads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Actividad_Alumno",
                c => new
                    {
                        ActividadId = c.Int(nullable: false),
                        AlumnoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ActividadId, t.AlumnoId })
                .ForeignKey("dbo.Actividads", t => t.ActividadId, cascadeDelete: true)
                .ForeignKey("dbo.Alumnoes", t => t.AlumnoId, cascadeDelete: true)
                .Index(t => t.ActividadId)
                .Index(t => t.AlumnoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actividad_Alumno", "AlumnoId", "dbo.Alumnoes");
            DropForeignKey("dbo.Actividad_Alumno", "ActividadId", "dbo.Actividads");
            DropIndex("dbo.Actividad_Alumno", new[] { "AlumnoId" });
            DropIndex("dbo.Actividad_Alumno", new[] { "ActividadId" });
            DropTable("dbo.Actividad_Alumno");
            DropTable("dbo.Actividads");
        }
    }
}
