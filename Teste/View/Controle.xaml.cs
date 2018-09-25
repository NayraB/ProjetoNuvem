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
            Veiculo veiculo = VeiculoDAO.BuscarVeiculoPorId(idVeiculo);

            DateTime dhSaida = DateTime.Now;
            txtHoraSaida.Text = dhSaida.ToString();
            DateTime dhEntrada = veiculo.HoraEntrada;



            //string[] splitHora = veiculo.HoraEntrada.Split(':');

            //DateTime DataEntrada = new DateTime(
            //    DateTime.Now.Year,
            //    DateTime.Now.Month,
            //    DateTime.Now.Day,
            //    int.Parse(splitHora[0]),
            //    int.Parse(splitHora[1]),
            //    int.Parse(splitHora[3])
            //    );

            //TimeSpan ts = dhSaida - veiculo.HoraEntrada ;
            // TimeSpan ts = dhSaida - DataEntrada ;

            var TotalHoras = (dhSaida - dhEntrada).TotalHours;
            var ValorTotal = (TotalHoras * 10.0);

            txtTotal.Text = ValorTotal.ToString();
          //  double valorTotal = ts.TotalHours * 10;

            //txtTotal.Text = valorTotal.ToString();


        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            cboVeiculo.ItemsSource = VeiculoDAO.RetornarVeiculo();
            cboVeiculo.DisplayMemberPath = "DescricaoComboModelo";
            cboVeiculo.SelectedValuePath = "IdVeiculo";
        }

        private void cboVeiculo_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            int idVeiculo = (int)cboVeiculo.SelectedValue;
            Veiculo veiculo = VeiculoDAO.BuscarVeiculoPorId(idVeiculo);
            txtMarcaVeiculo.Text = veiculo.MarcaVeiculo;
            txtModeloVeiculo.Text = veiculo.ModeloVeiculo;
            txtPlacaVeiculo.Text = veiculo.PlacaVeiculo;
            txtCorVeiculo.Text = veiculo.CorVeiculo;
            txtAnoVeiculo.Text = veiculo.AnoVeiculo.ToString();
            lbHoraEntrada.Content = veiculo.HoraEntrada;

        }
    }
    }
    
