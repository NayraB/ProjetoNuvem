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
    /// Interaction logic for ExcluirVeiculo.xaml
    /// </summary>
    public partial class ExcluirVeiculo : Window
    {
        public ExcluirVeiculo()
        {
            InitializeComponent();
        }


        private void btnExcluirVeiculo_Click(object sender, RoutedEventArgs e)
        {
            int idVeiculo = (int)cboListarVeiculo.SelectedValue;
            //Cliente cliente = ClienteDAO.BuscarClientePorId(IdCliente);

            // verifica se o metodo do ClienteDAO é verdadeiro
            if (VeiculoDAO.ExcluirVeiculo(idVeiculo))
            {

                MessageBox.Show("Veículo excluído com sucesso!",
                             "Loja",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);

                this.Close();

                //MessageBox.Show(cliente.NomeCliente);
            }
            else
            {
                MessageBox.Show("Veículo não pode ser excluído!",
                            "Loja",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);

                this.Close();

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboListarVeiculo.ItemsSource = VeiculoDAO.RetornarVeiculo();
            cboListarVeiculo.DisplayMemberPath = "ModeloVeiculo";
            cboListarVeiculo.SelectedValuePath = "IdVeiculo";
        }
    }
}
