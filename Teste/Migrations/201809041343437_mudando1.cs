namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mudando1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        IdVeiculo = c.Int(nullable: false, identity: true),
                        ModeloVeiculo = c.String(),
                        MarcaVeiculo = c.String(),
                        PlacaVeiculo = c.String(),
                        AnoVeiculo = c.String(),
                        CorVeiculo = c.String(),
                    })
                .PrimaryKey(t => t.IdVeiculo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veiculo");
        }
    }
}
