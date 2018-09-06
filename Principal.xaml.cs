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

namespace Teste.View
{
    /// <summary>
    /// Lógica interna para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            // é redirecionado para tela de Cadastro
            Cadastrar tela = new Cadastrar();
            tela.ShowDialog();
        }

        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {
            ListarCliente tela = new ListarCliente();
            tela.ShowDialog();
        }

        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            ExcluirCliente tela = new ExcluirCliente();
            tela.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            EditarCliente tela = new EditarCliente();
            tela.ShowDialog();
        }
    }
}
