namespace Multas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Multas", "CondutorFK", c => c.Int(nullable: false));
            AddColumn("dbo.Multas", "AgenteFK", c => c.Int(nullable: false));
            CreateIndex("dbo.Multas", "ViaturaFK");
            CreateIndex("dbo.Multas", "CondutorFK");
            CreateIndex("dbo.Multas", "AgenteFK");
            AddForeignKey("dbo.Multas", "AgenteFK", "dbo.Agentes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Multas", "CondutorFK", "dbo.Condutores", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Multas", "ViaturaFK", "dbo.Viaturas", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Multas", "ViaturaFK", "dbo.Viaturas");
            DropForeignKey("dbo.Multas", "CondutorFK", "dbo.Condutores");
            DropForeignKey("dbo.Multas", "AgenteFK", "dbo.Agentes");
            DropIndex("dbo.Multas", new[] { "AgenteFK" });
            DropIndex("dbo.Multas", new[] { "CondutorFK" });
            DropIndex("dbo.Multas", new[] { "ViaturaFK" });
            DropColumn("dbo.Multas", "AgenteFK");
            DropColumn("dbo.Multas", "CondutorFK");
        }
    }
}
