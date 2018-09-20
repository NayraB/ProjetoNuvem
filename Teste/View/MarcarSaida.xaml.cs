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

namespace Teste.View {
    /// <summary>
    /// Interaction logic for MarcarSaida.xaml
    /// </summary>
    public partial class MarcarSaida : Window {
        public MarcarSaida() {
            InitializeComponent();
            }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e) 
            {
            

            int idVeiculo = (int)cboEditarVeiculo.SelectedValue;

            Veiculo veiculoEditado = VeiculoDAO.BuscarVeiculoPorId(idVeiculo);

            //veiculoEditado.HoraSaida = txtHoraSaida.Text = DateTime.Now.ToLongTimeString();

            if (VeiculoDAO.EditarVeiculo(veiculoEditado)) {

                MessageBox.Show("Veículo editado com sucesso!",
                             "Loja",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);

                this.Close();

                //MessageBox.Show(cliente.NomeCliente);
                } else {
                MessageBox.Show("Veículo não foi editado",
                            "Loja",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);

                this.Close();

                }
            //MarcarSaida tela = new MarcarSaida();
            //tela.ShowDialog();
            }

        private void Window_Loaded(object sender, RoutedEventArgs e) 
            {
            cboEditarVeiculo.ItemsSource = VeiculoDAO.RetornarVeiculo();
            cboEditarVeiculo.DisplayMemberPath = "ModeloVeiculo";
            // Caminho que vai ser acionado para o Selected Value
            // Propriedade que vai ser utilizada quando meu Selected Value for acionado!!!!!!!!*********
            cboEditarVeiculo.SelectedValuePath = "IdVeiculo";
            }

      

        private void cboEditarVeiculo_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
            int idVeiculo = (int)cboEditarVeiculo.SelectedValue;
            Veiculo veiculo = VeiculoDAO.BuscarVeiculoPorId(idVeiculo);
            lblSaida.Content = DateTime.Now.ToLongTimeString();
            //lblTotal.Content = lblSaida - ;

            }
        }
}
