namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class consumoyrendimiendocamionetas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Camionetas", "ConsumoCada100Km", c => c.Int(nullable: false));
            AddColumn("dbo.Camionetas", "RelacionCantAlumnosConsumo", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Camionetas", "RelacionCantAlumnosConsumo");
            DropColumn("dbo.Camionetas", "ConsumoCada100Km");
        }
    }
}
