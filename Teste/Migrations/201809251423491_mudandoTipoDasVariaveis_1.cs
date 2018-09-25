namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mudandoTipoDasVariaveis_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Veiculo", "HoraEntrada", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Veiculo", "HoraSaida", c => c.DateTime());
            AlterColumn("dbo.Veiculo", "Total", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Veiculo", "Total", c => c.String());
            AlterColumn("dbo.Veiculo", "HoraSaida", c => c.String());
            AlterColumn("dbo.Veiculo", "HoraEntrada", c => c.String());
        }
    }
}
