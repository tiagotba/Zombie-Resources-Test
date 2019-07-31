namespace WebApiZombieResources.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoEstruturaBaseRecursos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_RECURSOS", "ST_STATUS", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_RECURSOS", "ST_STATUS");
        }
    }
}
