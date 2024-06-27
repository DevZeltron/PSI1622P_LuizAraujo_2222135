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
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void fcbtn_Click(object sender, EventArgs e)
        {

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
                            label3.Text = sb.ToString();
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
                            label4.Text = sb.ToString();
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
                            label6.Text = sb.ToString();
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
    }
}
