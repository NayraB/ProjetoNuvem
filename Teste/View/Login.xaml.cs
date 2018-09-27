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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Estacionamento estacionamento = EstacionamentoDAO.ValidarLogin(txtUsuario.Text, txtSenha.Text);
            if (estacionamento != null)
            {
                EstacionamentoStatic.estacionamento = estacionamento;
                Principal tela = new Principal();
                tela.ShowDialog();
            } else
            {
                MessageBox.Show("Login inválido!",
                        "SGAutomotiva",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
            }
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastrarEstacionamento tela = new CadastrarEstacionamento();
            tela.ShowDialog();
        }
    }
}
