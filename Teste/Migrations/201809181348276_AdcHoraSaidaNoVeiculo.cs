namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdcHoraSaidaNoVeiculo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculo", "HoraSaida", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculo", "HoraSaida");
        }
    }
}
