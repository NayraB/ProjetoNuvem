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

namespace Teste.View
{
    /// <summary>
    /// Interaction logic for ListarVeiculo.xaml
    /// </summary>
    public partial class ListarVeiculo : Window
    {
        public ListarVeiculo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // criar um retornar veículo no DAO
            dtgridCliente.ItemsSource = VeiculoDAO.RetornarVeiculo();
            dtgridCliente.DisplayMemberPath = "MarcaVeiculo";
            dtgridCliente.DisplayMemberPath = "ModeloVeiculo";
        }
    }
}
