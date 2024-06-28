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
    public partial class editaradm : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public editaradm()
        {
            InitializeComponent();
            CarregarDadosBebidas();
            CarregarDadosPizzas();
            CarregarBebidasNoDataGridView(); // Para bebidas
            CarregarPizzaNoDataGridView(); // Para pizzas
        }

        private void editaradm_Load(object sender, EventArgs e)
        {
            CarregarBebidasNoDataGridView();  // Para bebidas
            CarregarPizzaNoDataGridView(); // Para pizzas
            this.ControlBox = false;
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }
        private void CarregarDadosBebidas()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT bebida_id, nomebev AS Nome, preco FROM Bebida";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridBebida.DataSource = table;
            }
            /* try
              {
                  using (SqlConnection connection = new SqlConnection(stringconexao))
                  {
                      connection.Open();
                      using (SqlCommand command = new SqlCommand(query, connection))
                      {
                          using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                          {
                              DataTable dataTable = new DataTable();
                              adapter.Fill(dataTable);

                              // Vincule os dados ao controle DataGridView
                              dataGridBebida.DataSource = dataTable;
                          }
                      }
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Erro ao carregar os dados das bebidas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }*/
        }

        private void CarregarDadosPizzas()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT sabor_id, nome, preco FROM sabor_pizzas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridPizzas.DataSource = table;
            }

            /*try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Vincule os dados ao controle DataGridView
                            dataGridPizzas.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados das pizzas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridPizzas.DataSource = null; // Limpa o DataSource
            dataGridPizzas.DataSource = ObterDadosPizzas(); // Método para obter os dados das pizzas do banco de dados*/
        }

        private DataTable ObterDadosBebidas()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT nomebev AS Nome, preco AS Preço FROM Bebida";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados das bebidas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
        private DataTable ObterDadosPizzas()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT nome AS Nome, preco AS Preço FROM sabor_pizzas";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados das bebidas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        private void CarregarBebidasNoDataGridView()
        {
            DataTable dataTableB = ObterDadosBebidas();
            dataGridBebida.DataSource = dataTableB;
        }

        private void CarregarPizzaNoDataGridView()
        {
            DataTable dataTableB = ObterDadosPizzas();
            dataGridPizzas.DataSource = dataTableB;
        }

        private void EditarPbtn_Click(object sender, EventArgs e) //Pizza
        {
            // Verifica se uma pizza foi selecionada para edição
            if (dataGridPizzas.SelectedRows.Count > 0)
            {
                int pizzaId = Convert.ToInt32(dataGridPizzas.SelectedRows[0].Cells["sabor_id"].Value);

                // Abre o formulário de edição de pizza com o Id da pizza selecionada
                EditarPizzaForm editarPizzaForm = new EditarPizzaForm(pizzaId);
                editarPizzaForm.ShowDialog();

                // Atualiza o DataGridView de pizzas após a edição
                CarregarDadosPizzas();
            }
            else
            {
                MessageBox.Show("Selecione uma pizza para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e) //Bebida
        {
            // Verifica se uma bebida foi selecionada para edição
            if (dataGridBebida.SelectedRows.Count > 0)
            {
                int bebida_id = Convert.ToInt32(dataGridBebida.SelectedRows[0].Cells["bebida_id"].Value);

                // Abre o formulário de edição de bebida com o Id da bebida selecionada
                EditarBebidaForm editarBebidaForm = new EditarBebidaForm(bebida_id);
                editarBebidaForm.ShowDialog();

                // Atualiza o DataGridView de bebidas após a edição
                CarregarDadosBebidas();
            }
            else
            {
                MessageBox.Show("Selecione uma bebida para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
