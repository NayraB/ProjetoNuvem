using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model
{
    public class Estacionamento
    {
        [Key]
        public int IdEstacionamento { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
