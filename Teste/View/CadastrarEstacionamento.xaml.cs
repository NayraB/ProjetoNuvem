using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Teste.DAL;
using Teste.Model;

namespace Teste.View
{
    /// <summary>
    /// Lógica interna para CadastrarEstacionamento.xaml
    /// </summary>
    public partial class CadastrarEstacionamento : Window
    {
        public CadastrarEstacionamento()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Estacionamento estacionamento = new Estacionamento
            {
                Login = txtUsuario.Text,
                Senha = txtSenha.Text

            };

            EstacionamentoDAO.CadastrarEstacionamento(estacionamento);
            this.Close();
        }
    }
}
