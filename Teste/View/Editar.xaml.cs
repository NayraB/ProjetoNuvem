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
    /// Lógica interna para Editar.xaml
    /// </summary>
    public partial class Editar : Window
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            EditarCliente tela = new EditarCliente();
            tela.ShowDialog();

        }

        private void btnEditarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            EditarVeiculo tela = new EditarVeiculo();
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
