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
    /// Interaction logic for CadastrarVeiculo.xaml
    /// </summary>
    public partial class CadastrarVeiculo : Window
    {
        public CadastrarVeiculo()
        {
            InitializeComponent();
        }

        private void btnCadastrarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtModeloVeiculo.Text) 
                && !string.IsNullOrEmpty(txtMarcaVeiculo.Text)
                && !string.IsNullOrEmpty(txtAnoVeiculo.Text)
                && !string.IsNullOrEmpty(txtCorVeiculo.Text)
                //&& !string.IsNullOrEmpty(txtEntradaVeiculo.Text)
                && !string.IsNullOrEmpty(txtPlacaVeiculo.Text))
            {

                Veiculo veiculo = new Veiculo {
                    IdCliente = int.Parse(cboCliente.SelectedValue.ToString()),
                    //IdCliente = int.Parse(txtNomeCliente.Text),
                    ModeloVeiculo = txtModeloVeiculo.Text,
                    MarcaVeiculo = txtMarcaVeiculo.Text,
                    AnoVeiculo = txtAnoVeiculo.Text,
                    CorVeiculo = txtCorVeiculo.Text,
                    HoraEntrada = DateTime.Parse(txtEntradaVeiculo.Text),
                    /*DateTime.Now.ToString("dd/MM/yyyy")*/
                    PlacaVeiculo = txtPlacaVeiculo.Text
                    

                };

                // construir o VeiculoDAO
                if (VeiculoDAO.CadastrarVeiculo(veiculo))
                {
                    MessageBox.Show("Veículo cadastrado com sucesso!",
                        "SGAutomotiva",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veículo não cadastrado!",
                        "SGAutomotiva",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos Obrigatorios!",
                        "SGAutomotiva", MessageBoxButton.OK,
                        MessageBoxImage.Information);

            }
            this.Close();

        }

        private void cboCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int idCliente = (int)cboCliente.SelectedValue;
            Cliente cliente = ClienteDAO.BuscarClientePorId(idCliente);
            txtNomeCliente.Text = cliente.NomeCliente;
            txtSobrenomeCliente.Text = cliente.SobrenomeCliente;
            txtCpfCliente.Text = cliente.CpfCliente;
            txtTelefoneCliente.Text = cliente.TelefoneCliente;
            txtEntradaVeiculo.Text = DateTime.Now.ToLongTimeString();



        }

       
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            cboCliente.ItemsSource = ClienteDAO.RetornarCliente();
            cboCliente.DisplayMemberPath = "NomeCliente";
            // Caminho que vai ser acionado para o Selected Value
            // Propriedade que vai ser utilizada quando meu Selected Value for acionado!!!!!!!!*********
            cboCliente.SelectedValuePath = "IdCliente";
        }

        private void btn_voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
