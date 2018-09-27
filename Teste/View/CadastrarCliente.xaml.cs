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
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        
        public CadastrarCliente()
        {
            
            InitializeComponent();

        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNomeCliente.Text) && !string.IsNullOrEmpty(txtSobrenomeCliente.Text)
                && !string.IsNullOrEmpty(txtTelefoneCliente.Text) && !string.IsNullOrEmpty(txtCpfCliente.Text))
            {

                Cliente cliente = new Cliente
                {
                    NomeCliente = txtNomeCliente.Text,
                    SobrenomeCliente = txtSobrenomeCliente.Text,
                    TelefoneCliente = txtTelefoneCliente.Text,
                    CpfCliente = txtCpfCliente.Text,
                    IdEstacionamento = EstacionamentoStatic.estacionamento.IdEstacionamento

                };

                if (ClienteDAO.CadastrarCliente(cliente))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!",
                        "SGAutomotiva",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cliente não cadastrado!",
                        "SGAutomotiva",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos Obrigatorios!",
                        "SGAutomotiva", MessageBoxButton.OK,
                        MessageBoxImage.Error);

            }
           
        }

        private void btn_voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

