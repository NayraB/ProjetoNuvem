namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mudandoOTipoDaClasse : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "TelefoneCliente", c => c.String());
            AlterColumn("dbo.Cliente", "CpfCliente", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "CpfCliente", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "TelefoneCliente", c => c.Int(nullable: false));
        }
    }
}
