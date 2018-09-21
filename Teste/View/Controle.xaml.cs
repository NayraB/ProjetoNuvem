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

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            // criar um retornar veículo no DAO
            dtgridVeiculo.ItemsSource = VeiculoDAO.RetornarVeiculo();
            dtgridVeiculo.DisplayMemberPath = "MarcaVeiculo";
            dtgridVeiculo.DisplayMemberPath = "ModeloVeiculo";
            }


        private void btnRegistrarSaida_Click(object sender, RoutedEventArgs e) {

            Veiculo vSelecionado = (Veiculo)dtgridVeiculo.SelectedItem;
            v.HoraSaida = DateTime.Now.ToLongTimeString();
            dtgridVeiculo.ItemsSource = new List<Veiculo>() { v };
            btn = null;
                
            //MarcarSaida tela = new MarcarSaida();
            //tela.ShowDialog();

            }

        private Veiculo v;
        private Button btn;

        private void dtgridVeiculo_LoadingRow(object sender, DataGridRowEventArgs e) {
            v = (Veiculo)e.Row.DataContext;

            if(string.IsNullOrEmpty(v.HoraSaida)) {
                // mostrar botao
                btn = new Button();
                btn.Content = "Marcar Saída";
                btn.Click += btnRegistrarSaida_Click;

                // inserindo 

                //dtgridVeiculo.Columns[6].Cell.Controls = btn;
                }
            else {
                //mostrar textblock com a hora saida
                }

            }
        }
    }
