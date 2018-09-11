namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculo", "IdCliente", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculo", "IdCliente");
        }
    }
}
