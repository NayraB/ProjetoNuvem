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

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e) {
            cboVeiculo.ItemsSource = VeiculoDAO.RetornarVeiculo();
            cboVeiculo.DisplayMemberPath = "ModeloVeiculo";
            cboVeiculo.SelectedValuePath = "IdVeiculo";
        }

       

        private void cboVeiculo_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            int idVeiculo = (int)cboVeiculo.SelectedValue;
            Veiculo veiculo = VeiculoDAO.BuscarVeiculoPorId(idVeiculo);
            txtMarcaVeiculo.Text = veiculo.MarcaVeiculo;
            txtModeloVeiculo.Text = veiculo.ModeloVeiculo;
            txtPlacaVeiculo.Text = veiculo.PlacaVeiculo;
            txtCorVeiculo.Text = veiculo.CorVeiculo;
            txtEntradaVeiculo.Text = veiculo.HoraEntrada;
            txtAnoVeiculo.Text = veiculo.AnoVeiculo;
        }
    }
    }
    
