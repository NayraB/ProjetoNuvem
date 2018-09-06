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
    /// Lógica interna para EditarCliente.xaml
    /// </summary>
    public partial class EditarCliente : Window
    {
        public EditarCliente()
        {
            InitializeComponent();

        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

            int idCliente = (int)cboEditarCliente.SelectedValue;

            Cliente clienteEditado = ClienteDAO.BuscarClientePorId(idCliente);

            // pegando dado da tela e armazenando em uma variavel copia
            clienteEditado.NomeCliente = txtNomeEditar.Text;
            clienteEditado.SobrenomeCliente = txtSobrenomeEditar.Text;
            clienteEditado.TelefoneCliente = txtTelefoneCliente.Text;
            clienteEditado.CpfCliente = txtCpfCliente.Text;


            // verificar se o metodo bool é true
            if (ClienteDAO.EditarCliente(clienteEditado))
            {

                MessageBox.Show("Cliente editado com sucesso!",
                             "Loja",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);

                this.Close();

                //MessageBox.Show(cliente.NomeCliente);
            }
            else
            {
                MessageBox.Show("Cliente não foi editado",
                            "Loja",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);

                this.Close();

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idCliente = (int)cboEditarCliente.SelectedValue;
            Cliente cliente = ClienteDAO.BuscarClientePorId(idCliente);
            txtNomeEditar.Text = cliente.NomeCliente;
            txtSobrenomeEditar.Text = cliente.SobrenomeCliente;
            txtTelefoneCliente.Text = cliente.TelefoneCliente;
            txtCpfCliente.Text = cliente.CpfCliente;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboEditarCliente.ItemsSource = ClienteDAO.RetornarCliente();
            cboEditarCliente.DisplayMemberPath = "NomeCliente";
            // Caminho que vai ser acionado para o Selected Value
            // Propriedade que vai ser utilizada quando meu Selected Value for acionado!!!!!!!!*********
            cboEditarCliente.SelectedValuePath = "IdCliente";
        }
    }
}
