﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoC_
{
    public partial class pizzas : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public pizzas()
        {
            InitializeComponent();
            CarregarPrecoMargherita();
            CarregarPrecoPepperoni();
            CarregarPrecoQQueijo();
            CarregarPrecoPortuguesa();
            CarregarCalabreso();
            CarregarCatupiro();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void fcbtn_Click(object sender, EventArgs e)
        {
            // Criar uma lista para armazenar os preços das pizzas selecionadas
            List<decimal> precosPizzasSelecionadas = new List<decimal>();
            List<decimal> precosBebidas = new List<decimal>();

            // Adicionar os preços das pizzas selecionadas à lista
            AdicionarPrecoSeSelecionado(margeritocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(pepperonocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(queijocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(tugacheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(calabresocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(catupirocheck, precosPizzasSelecionadas);

            // Instanciar o formulário de pagamento passando os preços das pizzas
            pagamento pay = new pagamento(precosPizzasSelecionadas, precosBebidas); 

            pay.Show();
            this.Hide();
        }
        private void AdicionarPrecoSeSelecionado(CheckBox checkBox, List<decimal> listaPrecos)
        {
            if (checkBox.Checked && checkBox.Tag is decimal)
            {
                listaPrecos.Add((decimal)checkBox.Tag);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CarregarPrecoMargherita()
        {

            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = 1";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }

                            // Atualiza a label com os preços das pizzas
                            margerito.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das pizzas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void CarregarPrecoPepperoni()
        {
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = 2";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }

                            // Atualiza a label com os preços das pizzas
                            pepperono.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das pizzas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void CarregarPrecoQQueijo()
        {
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = 3";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }

                            // Atualiza a label com os preços das pizzas
                            queijudo.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das pizzas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void CarregarPrecoPortuguesa()
        {
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = 6";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }

                            // Atualiza a label com os preços das pizzas
                            portugueso.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das pizzas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void CarregarCalabreso()
        {
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = 5";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }

                            // Atualiza a label com os preços das pizzas
                            calabreso.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das pizzas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void CarregarCatupiro()
        {
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = 4";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder sb = new StringBuilder();
                            while (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }


                            // Atualiza a label com os preços das pizzas
                            catupiro.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das pizzas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void pizzas_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void margeritocheck_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bebidas bev =  new bebidas();

            bev.Show();
        }
    }
}
