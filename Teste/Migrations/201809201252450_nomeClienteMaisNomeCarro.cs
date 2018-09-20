namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nomeClienteMaisNomeCarro : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Veiculo", "IdCliente");
            AddForeignKey("dbo.Veiculo", "IdCliente", "dbo.Cliente", "IdCliente", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculo", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.Veiculo", new[] { "IdCliente" });
        }
    }
}
