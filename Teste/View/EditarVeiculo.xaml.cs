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
using Teste.Model;

namespace Teste.View
{
    /// <summary>
    /// Interaction logic for EditarVeiculo.xaml
    /// </summary>
    public partial class EditarVeiculo : Window
    {
        public EditarVeiculo()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

            int idVeiculo = (int)cboEditarVeiculo.SelectedValue;

            Veiculo veiculoEditado = VeiculoDAO.BuscarVeiculoPorId(idVeiculo, EstacionamentoStatic.estacionamento.IdEstacionamento);

            // pegando dado da tela e armazenando em uma variavel copia
            veiculoEditado.MarcaVeiculo = txtMarcaVeiculo.Text;
            veiculoEditado.ModeloVeiculo = txtModeloVeiculo.Text;
            veiculoEditado.PlacaVeiculo = txtPlacaVeiculo.Text;
            veiculoEditado.CorVeiculo = txtCorVeiculo.Text;
            veiculoEditado.HoraEntrada = DateTime.Parse(txtEntradaVeiculo.Text);
            veiculoEditado.AnoVeiculo = txtAnoVeiculo.Text;


            // verificar se o metodo bool é true
            if (VeiculoDAO.EditarVeiculo(veiculoEditado))
            {

                MessageBox.Show("Veículo editado com sucesso!",
                             "Loja",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information);

                this.Close();

                //MessageBox.Show(cliente.NomeCliente);
            }
            else
            {
                MessageBox.Show("Veículo não foi editado",
                            "Loja",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);

                this.Close();

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idVeiculo = (int)cboEditarVeiculo.SelectedValue;
            Veiculo veiculo = VeiculoDAO.BuscarVeiculoPorId(idVeiculo, EstacionamentoStatic.estacionamento.IdEstacionamento);
            txtMarcaVeiculo.Text = veiculo.MarcaVeiculo;
            txtModeloVeiculo.Text = veiculo.ModeloVeiculo;
            txtPlacaVeiculo.Text = veiculo.PlacaVeiculo;
            txtCorVeiculo.Text = veiculo.CorVeiculo;
            txtEntradaVeiculo.Text = veiculo.HoraEntrada.ToString();
            txtAnoVeiculo.Text = veiculo.AnoVeiculo.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            cboEditarVeiculo.ItemsSource = VeiculoDAO.RetornarVeiculo(EstacionamentoStatic.estacionamento.IdEstacionamento);
            cboEditarVeiculo.DisplayMemberPath = "DescricaoCombo";
            cboEditarVeiculo.SelectedValuePath = "IdVeiculo";
        }

        private void btn_voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }
