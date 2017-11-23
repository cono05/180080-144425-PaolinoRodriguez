namespace Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Diagnostics.CodeAnalysis;
    public partial class consumoyrendimiendocamionetas : DbMigration
    {
        [ExcludeFromCodeCoverage]
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
