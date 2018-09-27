namespace Teste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdcEstacionamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        NomeCliente = c.String(),
                        SobrenomeCliente = c.String(),
                        TelefoneCliente = c.String(),
                        CpfCliente = c.String(),
                        IdEstacionamento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.Estacionamentoes",
                c => new
                    {
                        IdEstacionamento = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.IdEstacionamento);
            
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
                        HoraEntrada = c.DateTime(nullable: false),
                        HoraSaida = c.DateTime(),
                        Total = c.Double(),
                        IdCliente = c.Int(nullable: false),
                        IdEstacionamento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdVeiculo)
                .ForeignKey("dbo.Cliente", t => t.IdCliente, cascadeDelete: true)
                .Index(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculo", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.Veiculo", new[] { "IdCliente" });
            DropTable("dbo.Veiculo");
            DropTable("dbo.Estacionamentoes");
            DropTable("dbo.Cliente");
        }
    }
}
