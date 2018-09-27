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
    /// Interaction logic for Cadastrar.xaml
    /// </summary>
    public partial class Cadastrar : Window
    {
       
        public Cadastrar()
        {
            
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente tela = new CadastrarCliente();
            tela.ShowDialog();
        }

        private void btnCadastrarVeiculo_Click(object sender, RoutedEventArgs e)
        {
            CadastrarVeiculo tela = new CadastrarVeiculo();
            tela.ShowDialog();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            // fechar essa janela
            this.Close();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            // fechar todas as janelas
            Environment.Exit(0);
        }
    }
}
