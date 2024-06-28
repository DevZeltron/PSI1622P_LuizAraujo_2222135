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

        public List<decimal> ObterPrecosBebidasSelecionadas()
        {
            List<decimal> precosBebidasSelecionadas = new List<decimal>();
            AdicionarPrecoSeSelecionadoBebidas(pepsicheck, precosBebidasSelecionadas);
            AdicionarPrecoSeSelecionadoBebidas(fantacheck, precosBebidasSelecionadas);
            AdicionarPrecoSeSelecionadoBebidas(cocazerocheck, precosBebidasSelecionadas);
            AdicionarPrecoSeSelecionadoBebidas(Upcheck, precosBebidasSelecionadas);
            AdicionarPrecoSeSelecionadoBebidas(guaranacheck, precosBebidasSelecionadas);
            AdicionarPrecoSeSelecionadoBebidas(sumolcheck, precosBebidasSelecionadas);
            return precosBebidasSelecionadas;
        }


        private void AdicionarPrecoSeSelecionadoBebidas(CheckBox checkbox, List<decimal> listaDePrecos)
        {
            if (checkbox.Checked && checkbox.Tag != null)
            {
                listaDePrecos.Add((decimal)checkbox.Tag);
            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");
                                pepslbl.Text = $"{nome}: € {preco:F2}";
                                pepsicheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");
                                fantalbl.Text = $"{nome}: € {preco:F2}";
                                fantacheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");
                                cocazerolbl.Text = $"{nome}: € {preco:F2}";
                                cocazerocheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");
                                lblUp.Text = $"{nome}: € {preco:F2}";
                                Upcheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");
                                guaranalbl.Text = $"{nome}: € {preco:F2}";
                                guaranacheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
                            if (reader.Read())
                            {
                                string nome = reader["nomebev"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");
                                sumolbl.Text = $"{nome}: € {preco:F2}";
                                sumolcheck.Tag = preco;  // Armazena o preço na propriedade Tag
                            }
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
