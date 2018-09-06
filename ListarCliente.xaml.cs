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
    /// Lógica interna para ListarCliente.xaml
    /// </summary>
    public partial class ListarCliente : Window
    {
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dtgridCliente.ItemsSource = ClienteDAO.RetornarCliente();
            dtgridCliente.DisplayMemberPath = "NomeCliente";
            dtgridCliente.DisplayMemberPath = "SobrenomeCliente";
            
            
        }
    }

    
}
