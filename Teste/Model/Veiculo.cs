using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model {
    [Table("Veiculo")]
    class Veiculo {
        // colocar a chave secundária (vincular o cliente com o veiculo)
        [Key]
        public int IdVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string MarcaVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public string AnoVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }
        public Double Total { get; set; }


        public int IdCliente { get; set; }
        public virtual Cliente _Cliente { get; set; }

        public virtual string DescricaoCombo {
            get {
                return PlacaVeiculo + " - " + _Cliente.NomeCliente;
            }
        }

        public virtual string DescricaoComboModelo {
            get {
                return ModeloVeiculo + " - " + _Cliente.NomeCliente;
            }
        }




    }
}
