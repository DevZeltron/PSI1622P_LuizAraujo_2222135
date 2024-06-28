using Microsoft.Data.SqlClient;
using System;
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
    public partial class bebidas : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public bebidas()
        {
            InitializeComponent();
            LoadPepso();
            LoadFanto();
            LoadCocaZero();
            Load7Upo();
            LoadGuarana();
            LoadSumol();
        }

        private void pepslbl_Click(object sender, EventArgs e)
        {

        }

        private void LoadPepso()
        {
            string query = "SELECT nomebev, preco FROM Bebida WHERE bebida_id = 1";

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
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }


                            // Atualiza a label com os preços das pizzas
                            pepslbl.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das bebidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadFanto()
        {
            string query = "SELECT nomebev, preco FROM Bebida WHERE bebida_id = 2";

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
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }


                            // Atualiza a label com os preços das pizzas
                            fantalbl.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das bebidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadCocaZero()
        {
            string query = "SELECT nomebev, preco FROM Bebida WHERE bebida_id = 3";

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
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }


                            // Atualiza a label com os preços das pizzas
                            cocazerolbl.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das bebidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Load7Upo()
        {
            string query = "SELECT nomebev, preco FROM Bebida WHERE bebida_id = 4";

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
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }


                            // Atualiza a label com os preços das pizzas
                            lblUp.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das bebidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadGuarana()
        {
            string query = "SELECT nomebev, preco FROM Bebida WHERE bebida_id = 5";

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
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }


                            // Atualiza a label com os preços das pizzas
                            guaranalbl.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das bebidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadSumol()
        {
            string query = "SELECT nomebev, preco FROM Bebida WHERE bebida_id = 6";

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
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");

                            }


                            // Atualiza a label com os preços das pizzas
                            sumolbl.Text = sb.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os preços das bebidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fantalbl_Click(object sender, EventArgs e)
        {

        }

        private void voltarbtn_Click(object sender, EventArgs e)
        {
            pizzas SPizza = new pizzas();
           SPizza.Show();
            this.Close();
        }

        private void pepsicheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fantacheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cocazerocheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Upcheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guaranacheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bebidas_Load(object sender, EventArgs e)
        {

        }

        private void sumolcheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
