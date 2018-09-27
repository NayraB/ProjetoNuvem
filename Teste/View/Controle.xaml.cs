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
    /// Interaction logic for Controle.xaml
    /// </summary>
    public partial class Controle : Window {
        public Controle() {
            InitializeComponent();
            }

        private void btn_voltar_Click(object sender, RoutedEventArgs e) {
            this.Close();
            }

        private void btnMarcarSaida_Click_1(object sender, RoutedEventArgs e) {

            int idVeiculo = (int)cboVeiculo.SelectedValue;
            Veiculo veiculo = VeiculoDAO.BuscarVeiculoPorId(idVeiculo, EstacionamentoStatic.estacionamento.IdEstacionamento);

            DateTime dhSaida = DateTime.Now;
            lblHoraSaida.Content = dhSaida.ToString("HH:mm:ss");

            DateTime dhEntrada = veiculo.HoraEntrada;
            lblHoraEntrada.Content = dhEntrada.ToString("HH:mm:ss");

            var TotalHoras = (dhSaida - dhEntrada).TotalHours;
            var ValorTotal = (TotalHoras * 10.0);

            lblValorTotal.Content = ValorTotal.ToString("N2");
            
            }

        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            cboVeiculo.ItemsSource = VeiculoDAO.RetornarVeiculoSemSaida(EstacionamentoStatic.estacionamento.IdEstacionamento);
            cboVeiculo.DisplayMemberPath = "DescricaoComboModelo";
            cboVeiculo.SelectedValuePath = "IdVeiculo";
            }

        private void cboVeiculo_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            // fazer um if para aparecer só os veículos que não têm hora de saída
            int idVeiculo = (int)cboVeiculo.SelectedValue;
            Veiculo veiculo = VeiculoDAO.BuscarVeiculoPorId(idVeiculo, EstacionamentoStatic.estacionamento.IdEstacionamento);
            lblHoraSaida.Content = veiculo.HoraSaida;
            lblHoraEntrada.Content = veiculo.HoraEntrada.ToString("HH:mm");
            lblValorTotal.Content = veiculo.Total;
            txtMarcaVeiculo.Text = veiculo.MarcaVeiculo;
            txtModeloVeiculo.Text = veiculo.ModeloVeiculo;
            txtPlacaVeiculo.Text = veiculo.PlacaVeiculo;
            txtCorVeiculo.Text = veiculo.CorVeiculo;
            //txtEntradaVeiculo.Text = veiculo.HoraEntrada.ToString("HH:mm");
            txtAnoVeiculo.Text = veiculo.AnoVeiculo.ToString();

            }

        private void btnSalvar_Click(object sender, RoutedEventArgs e) {

            if (!string.IsNullOrEmpty(txtModeloVeiculo.Text)
            && !string.IsNullOrEmpty(txtMarcaVeiculo.Text)
            && !string.IsNullOrEmpty(txtAnoVeiculo.Text)
            && !string.IsNullOrEmpty(txtCorVeiculo.Text)
            //&& !string.IsNullOrEmpty(txtEntradaVeiculo.Text)
            && !string.IsNullOrEmpty(txtPlacaVeiculo.Text)
            && cboVeiculo.SelectedItem != null) {
                Veiculo VeiculoNovo = (Veiculo)this.cboVeiculo.SelectedItem;

                VeiculoNovo.HoraSaida = DateTime.Parse(lblHoraSaida.Content.ToString());
                VeiculoNovo.Total = Double.Parse(lblValorTotal.Content.ToString());


                // construir o VeiculoDAO
                if (VeiculoDAO.EditarVeiculo(VeiculoNovo)) {
                    MessageBox.Show("Salvo com sucesso!",
                        "SGAutomotiva",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    this.Close();
                    } else {
                    MessageBox.Show("Algo deu errado!",
                        "SGAutomotiva",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    }
                }

            }
        }
    }

