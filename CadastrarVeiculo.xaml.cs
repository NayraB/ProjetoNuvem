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
            if (!string.IsNullOrEmpty(txtModeloVeiculo.Text) && !string.IsNullOrEmpty(txtMarcaVeiculo.Text)
                && !string.IsNullOrEmpty(txtCorVeiculo.Text) && !string.IsNullOrEmpty(txtPlacaVeiculo.Text))
            {

                Veiculo veiculo = new Veiculo
                {
                    ModeloVeiculo = txtModeloVeiculo.Text,
                    MarcaVeiculo = txtMarcaVeiculo.Text,
                    CorVeiculo = txtCorVeiculo.Text,
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
    }
}
