namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdcCampoNoVeiculo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculo", "HoraEntrada", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculo", "HoraEntrada");
        }
    }
}
