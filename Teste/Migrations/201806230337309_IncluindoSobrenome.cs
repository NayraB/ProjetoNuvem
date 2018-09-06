namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncluindoSobrenome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "SobrenomeCliente", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "SobrenomeCliente");
        }
    }
}
