using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica interna para ExcluirCliente.xaml
    /// </summary>
    public partial class ExcluirCliente : Window
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }


        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            int idCliente = (int)cboListarCliente.SelectedValue;
           
            //Cliente cliente = ClienteDAO.BuscarClientePorId(IdCliente);

            // verifica se o metodo do ClienteDAO é verdadeiro
            if (ClienteDAO.ExcluirCliente(idCliente, EstacionamentoStatic.estacionamento.IdEstacionamento)){


                VeiculoDAO.ExcluirVeiculosPorClienteID(idCliente);
                MessageBox.Show("Cliente excluído com sucesso!",
                             "Loja",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);

                this.Close();

                //MessageBox.Show(cliente.NomeCliente);
            } else
            {
                MessageBox.Show("Cliente não foi excluído!",
                            "Loja",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);

                this.Close();

            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            cboListarCliente.ItemsSource = ClienteDAO.RetornarCliente(EstacionamentoStatic.estacionamento.IdEstacionamento);
            cboListarCliente.DisplayMemberPath = "NomeCliente";
            cboListarCliente.SelectedValuePath = "IdCliente";

        }

        private void btn_voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
