using Microsoft.Data.SqlClient;
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
            List<decimal> precosPizzasSelecionadas = new List<decimal>();

            AdicionarPrecoSeSelecionado(margeritocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(pepperonocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(queijocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(tugacheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(calabresocheck, precosPizzasSelecionadas);
            AdicionarPrecoSeSelecionado(catupirocheck, precosPizzasSelecionadas);

            // Abre o formulário de bebidas e espera até que ele seja fechado
            bebidas bevForm = new bebidas();
            

            // Obtém os preços das bebidas selecionadas
            List<decimal> precosBebidasSelecionadas = bevForm.ObterPrecosBebidasSelecionadas();

            pagamento pay = new pagamento(precosPizzasSelecionadas, precosBebidasSelecionadas);
            pay.Show();
            this.Hide();
        }

        private void AdicionarPrecoSeSelecionado(CheckBox checkbox, List<decimal> listaDePrecos)
        {
            if (checkbox.Checked && checkbox.Tag != null)
            {
                listaDePrecos.Add((decimal)checkbox.Tag);
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
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                margerito.Text = $"{nome}: € {preco:F2}";
                                margeritocheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                pepperono.Text = $"{nome}: € {preco:F2}";
                                pepperonocheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                queijudo.Text = $"{nome}: € {preco:F2}";
                                queijocheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                portugueso.Text = $"{nome}: € {preco:F2}";
                                tugacheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                calabreso.Text = $"{nome}: € {preco:F2}";
                                calabresocheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                catupiro.Text = $"{nome}: € {preco:F2}";
                                catupirocheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
