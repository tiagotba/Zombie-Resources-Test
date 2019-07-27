namespace WebApiZombieResources.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoEstruturaBaseSobrevivencia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_ITEM_RECURSO_ENTRADA",
                c => new
                    {
                        ID_RECURSO_ENTRADA = c.Int(nullable: false, identity: true),
                        REC_ID = c.Int(nullable: false),
                        ITEM_REC_ID = c.Int(nullable: false),
                        ITEM_LOTE = c.String(nullable: false, maxLength: 20),
                        QTD_LOTE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_RECURSO_ENTRADA)
                .ForeignKey("dbo.TB_RECURSOS", t => t.REC_ID, cascadeDelete: true)
                .ForeignKey("dbo.TB_RECURSO_ENTRADA", t => t.ITEM_REC_ID, cascadeDelete: true)
                .Index(t => t.REC_ID)
                .Index(t => t.ITEM_REC_ID);
            
            CreateTable(
                "dbo.TB_RECURSOS",
                c => new
                    {
                        ID_RECURSO = c.Int(nullable: false, identity: true),
                        DESC_DESCRICAO = c.String(nullable: false, maxLength: 150),
                        QTD_ESTOQUE = c.Int(nullable: false),
                        OBS_OBSERVACAO = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID_RECURSO);
            
            CreateTable(
                "dbo.TB_ITEM_RECURSO_SAIDA",
                c => new
                    {
                        ID_RECURSO_SAIDA = c.Int(nullable: false, identity: true),
                        REC_ID = c.Int(nullable: false),
                        ITEM_REC_ID = c.Int(nullable: false),
                        QTD_SAIDA = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_RECURSO_SAIDA)
                .ForeignKey("dbo.TB_RECURSOS", t => t.REC_ID, cascadeDelete: true)
                .ForeignKey("dbo.TB_RECURSO_SAIDA", t => t.ITEM_REC_ID, cascadeDelete: true)
                .Index(t => t.REC_ID)
                .Index(t => t.ITEM_REC_ID);
            
            CreateTable(
                "dbo.TB_RECURSO_SAIDA",
                c => new
                    {
                        ID_RECURSO_SAIDA = c.Int(nullable: false, identity: true),
                        DT_SAIDA = c.DateTime(nullable: false),
                        DT_PEDIDO = c.DateTime(nullable: false),
                        TOTAL_ENTRADA = c.Double(nullable: false),
                        SOBRV_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_RECURSO_SAIDA)
                .ForeignKey("dbo.TB_SOBREVIVENTES", t => t.SOBRV_ID, cascadeDelete: true)
                .Index(t => t.SOBRV_ID);
            
            CreateTable(
                "dbo.TB_SOBREVIVENTES",
                c => new
                    {
                        ID_SOBREVIVENTE = c.Int(nullable: false, identity: true),
                        NOME = c.String(nullable: false, maxLength: 150),
                        GENERO = c.String(nullable: false, maxLength: 2),
                        IDADE = c.Int(nullable: false),
                        HashSeguranca = c.String(),
                        LOGIN = c.String(nullable: false, maxLength: 20),
                        ADMIN = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_SOBREVIVENTE);
            
            CreateTable(
                "dbo.TB_RECURSO_ENTRADA",
                c => new
                    {
                        ID_RECURSO_ENTRADA = c.Int(nullable: false, identity: true),
                        DT_ENTRADA = c.DateTime(nullable: false),
                        DT_PEDIDO = c.DateTime(nullable: false),
                        TOTAL_ENTRADA = c.Double(nullable: false),
                        SOBRV_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_RECURSO_ENTRADA)
                .ForeignKey("dbo.TB_SOBREVIVENTES", t => t.SOBRV_ID, cascadeDelete: true)
                .Index(t => t.SOBRV_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_ITEM_RECURSO_ENTRADA", "ITEM_REC_ID", "dbo.TB_RECURSO_ENTRADA");
            DropForeignKey("dbo.TB_ITEM_RECURSO_ENTRADA", "REC_ID", "dbo.TB_RECURSOS");
            DropForeignKey("dbo.TB_ITEM_RECURSO_SAIDA", "ITEM_REC_ID", "dbo.TB_RECURSO_SAIDA");
            DropForeignKey("dbo.TB_RECURSO_SAIDA", "SOBRV_ID", "dbo.TB_SOBREVIVENTES");
            DropForeignKey("dbo.TB_RECURSO_ENTRADA", "SOBRV_ID", "dbo.TB_SOBREVIVENTES");
            DropForeignKey("dbo.TB_ITEM_RECURSO_SAIDA", "REC_ID", "dbo.TB_RECURSOS");
            DropIndex("dbo.TB_RECURSO_ENTRADA", new[] { "SOBRV_ID" });
            DropIndex("dbo.TB_RECURSO_SAIDA", new[] { "SOBRV_ID" });
            DropIndex("dbo.TB_ITEM_RECURSO_SAIDA", new[] { "ITEM_REC_ID" });
            DropIndex("dbo.TB_ITEM_RECURSO_SAIDA", new[] { "REC_ID" });
            DropIndex("dbo.TB_ITEM_RECURSO_ENTRADA", new[] { "ITEM_REC_ID" });
            DropIndex("dbo.TB_ITEM_RECURSO_ENTRADA", new[] { "REC_ID" });
            DropTable("dbo.TB_RECURSO_ENTRADA");
            DropTable("dbo.TB_SOBREVIVENTES");
            DropTable("dbo.TB_RECURSO_SAIDA");
            DropTable("dbo.TB_ITEM_RECURSO_SAIDA");
            DropTable("dbo.TB_RECURSOS");
            DropTable("dbo.TB_ITEM_RECURSO_ENTRADA");
        }
    }
}
