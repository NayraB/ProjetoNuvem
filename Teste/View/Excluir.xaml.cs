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
    /// Interaction logic for Excluir.xaml
    /// </summary>
    public partial class Excluir : Window
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            ExcluirCliente tela = new ExcluirCliente();
            tela.ShowDialog();
        }

        private void btnExcluirVeiculo_Click(object sender, RoutedEventArgs e)
        {
            ExcluirVeiculo tela = new ExcluirVeiculo();
            tela.ShowDialog();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
