namespace WebApiZombieResources.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoEstruturaBaseSobrevivencia : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_RECURSO_SAIDA", name: "TOTAL_ENTRADA", newName: "TOTAL_SAIDA");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.TB_RECURSO_SAIDA", name: "TOTAL_SAIDA", newName: "TOTAL_ENTRADA");
        }
    }
}
