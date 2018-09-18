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
    /// Interaction logic for Listar.xaml
    /// </summary>
    public partial class Listar : Window
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void btnListarCliente_Click(object sender, RoutedEventArgs e)
        {
            // redirecionar para a tela da lista de cliente
            ListarCliente tela = new ListarCliente();
            tela.ShowDialog();
        }

        private void btnListarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            // redirecionar para a tela da lista de veículo
            ListarVeiculo tela = new ListarVeiculo();
            tela.ShowDialog();

        }

        private void btnListarTodos_Click(object sender, RoutedEventArgs e)
        {
            // redirecionar para a tela da lista de todos
            ListarTodos tela = new ListarTodos();
            tela.ShowDialog();

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
