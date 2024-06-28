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
            CarregarPizzaNoDataGridView();
            CarregarBebidasNoDataGridView();
        }

        private void editaradm_Load(object sender, EventArgs e)
        {
            CarregarBebidasNoDataGridView();  // Para bebidas
            CarregarPizzaNoDataGridView(); // Para pizzas
            this.ControlBox = false;
        }

        /*private void bigLabel1_Click(object sender, EventArgs e)
        {

        }*/
        

        private DataTable ObterDadosBebidas()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string query = "SELECT bebida_id AS Id, nomebev AS Nome, preco AS Preço FROM Bebida";

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
                string query = "SELECT sabor_id AS Id, nome AS Nome, preco AS Preço FROM sabor_pizzas";

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
                MessageBox.Show("Erro ao obter dados das pizzas: " + ex.Message);
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

            /*
            // Configurar as colunas do DataGridView
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "Id"; // DataPropertyName deve corresponder ao nome da coluna no DataTable
            colId.HeaderText = "ID"; // Cabeçalho da coluna exibido no DataGridView
            dataGridBebida.Columns.Add(colId);

            // Configuração da coluna do Nome da bebida
            DataGridViewTextBoxColumn colNome = new DataGridViewTextBoxColumn();
            colNome.DataPropertyName = "Nome"; // DataPropertyName deve corresponder ao nome da coluna no DataTable
            colNome.HeaderText = "Nome"; // Cabeçalho da coluna exibido no DataGridView
            dataGridBebida.Columns.Add(colNome);

            // Configuração da coluna do Preço da bebida
            DataGridViewTextBoxColumn colPreco = new DataGridViewTextBoxColumn();
            colPreco.DataPropertyName = "Preço"; // DataPropertyName deve corresponder ao nome da coluna no DataTable
            colPreco.HeaderText = "Preço"; // Cabeçalho da coluna exibido no DataGridView
            dataGridBebida.Columns.Add(colPreco);*/

            dataGridBebida.DataSource = dataTableB;
        }

        private void CarregarPizzaNoDataGridView()
        {
            DataTable dataTableB = ObterDadosPizzas();
            dataGridPizzas.DataSource = dataTableB;
        }

        private void EditarPbtn_Click(object sender, EventArgs e) //Pizza
        {
            if (dataGridPizzas.SelectedRows.Count > 0)
            {
                int pizzaId = Convert.ToInt32(dataGridPizzas.SelectedRows[0].Cells["Id"].Value);

                // Abre o formulário de edição de pizza com o Id da pizza selecionada
                EditarPizzaForm editarPizzaForm = new EditarPizzaForm(pizzaId);
                if (editarPizzaForm.ShowDialog() == DialogResult.OK)
                {
                    CarregarPizzaNoDataGridView(); // Atualiza o DataGridView de pizzas após a edição
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pizza para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e) //Bebida
        {
            if (dataGridBebida.SelectedRows.Count > 0)
            {
                int bebidaId = Convert.ToInt32(dataGridBebida.SelectedRows[0].Cells["Id"].Value);

                // Abre o formulário de edição de bebida com o Id da bebida selecionada
                EditarBebidaForm editarBebidaForm = new EditarBebidaForm(bebidaId);
                if (editarBebidaForm.ShowDialog() == DialogResult.OK)
                {
                    CarregarBebidasNoDataGridView(); // Atualiza o DataGridView de bebidas após a edição
                }
            }
            else
            {
                MessageBox.Show("Selecione uma bebida para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
