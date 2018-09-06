namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mudandoAsClassesIncluindoVeiculo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "TelefoneCliente", c => c.Int(nullable: false));
            AddColumn("dbo.Cliente", "CpfCliente", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "CpfCliente");
            DropColumn("dbo.Cliente", "TelefoneCliente");
        }
    }
}
