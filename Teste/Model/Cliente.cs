using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model
{
    [Table("Cliente")]
    class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string SobrenomeCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string CpfCliente { get; set; }
        public int IdEstacionamento { get; set; }
    }
}
