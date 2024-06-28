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
    public partial class adcadm : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public adcadm()
        {
            InitializeComponent();
        }

        private void adcadm_Load(object sender, EventArgs e)
        {
            CarregarDadosPizzas();
            CarregarDadosBebidas();
            this.ControlBox = false;
        }

        private void CarregarDadosPizzas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();

                    string sql = "SELECT sabor_id, nome, preco FROM sabor_pizzas";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Vincular os dados à DataGridView
                    dataGridViewSaborPizzas.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }
        private void CarregarDadosBebidas()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();

                    string sql = "SELECT bebida_id, nomebev, preco FROM Bebida";

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Vincular os dados à DataGridView
                    dataGridViewBebidas.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados de bebidas: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdicionarPizzas formAdicionar = new FormAdicionarPizzas();
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                // Atualizar a DataGridView após adicionar nova pizza
                CarregarDadosPizzas();
            }

        }

        private void adcBevbtn_Click(object sender, EventArgs e)
        {
            FormAdicionarBebidas formAdicionar = new FormAdicionarBebidas();
            if (formAdicionar.ShowDialog() == DialogResult.OK)
            {
                // Atualizar a DataGridView após adicionar nova bebida
                CarregarDadosBebidas();
            }
        }
    }
}
