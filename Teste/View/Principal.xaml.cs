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

namespace Teste.View
{
    /// <summary>
    /// Lógica interna para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            // é redirecionado para tela de Cadastro
            Cadastrar tela = new Cadastrar();
            tela.ShowDialog();
        }

        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {
            Listar tela = new Listar();
            tela.ShowDialog();
        }

        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            Excluir tela = new Excluir();
            tela.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            Editar tela = new Editar();
            tela.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            Controle tela = new Controle();
            tela.ShowDialog();
        }

        private void btnServicos_Click(object sender, RoutedEventArgs e)
        {
            Servicos tela = new Servicos();
            tela.ShowDialog();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e) {
            this.Close();
            }
        }
}
