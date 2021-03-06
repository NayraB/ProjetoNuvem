﻿using System;
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

namespace Teste.View
{
    /// <summary>
    /// Interaction logic for ListarTodos.xaml
    /// </summary>
    public partial class ListarTodos : Window
    {
        public ListarTodos()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // criar um metodo para listar todos os veículos e clientes
            dtgridTodos.ItemsSource = VeiculoDAO.RetornarVeiculo(EstacionamentoStatic.estacionamento.IdEstacionamento);
            
            dtgridTodos.DisplayMemberPath = "IdVeiculo";

            //dtgridTodos.ItemsSource = ClienteDAO.RetornarCliente();
            //dtgridTodos.DisplayMemberPath = "IdCliente";
        }

        private void btn_voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
