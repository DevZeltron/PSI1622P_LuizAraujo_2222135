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
    public partial class removeradm : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public removeradm()
        {
            InitializeComponent();
            LoadPizzasGrid(); // Carrega os dados das pizzas no DataGridView
            LoadBebidasGrid(); // Carrega os dados das bebidas no DataGridView
        }

        private void removeradm_Load(object sender, EventArgs e)
        {
            
            this.ControlBox = false;

        }


        // Método para obter os dados das bebidas do banco de dados
        private DataTable ObterDadosPizzas()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = "SELECT sabor_id, nome, preco AS Preço FROM sabor_pizzas";

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

        // Método para obter os dados das pizzas do banco de dados
        private DataTable ObterDadosBebidas()
        {
            DataTable dataTable = new DataTable();
            try
            {
                string query = "SELECT bebida_id, nomebev AS Nome, preco AS Preço FROM Bebida";

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

        // Métodos para carregar os dados das pizzas e bebidas nos DataGridViews
        private void LoadBebidasGrid()
        {
            DataTable dataTableB = ObterDadosBebidas();
            dataGridBebidasR.DataSource = dataTableB;
        }
        private void LoadPizzasGrid()
        {
            DataTable dataTableB = ObterDadosPizzas();
            dataGridSaborPizzasR.DataSource = dataTableB;
        }
        private void removerP_Click(object sender, EventArgs e) //Parte das pizzas aqui
        {
            if (dataGridSaborPizzasR.SelectedRows.Count > 0)
            {
                int pizzaId = Convert.ToInt32(dataGridSaborPizzasR.SelectedRows[0].Cells["sabor_id"].Value);

                // Abre o formulário de remoção de pizza com o Id da pizza selecionada
                RemovePizza removePizzaForm = new RemovePizza(pizzaId);
                if (removePizzaForm.ShowDialog() == DialogResult.OK)
                {
                    // Atualiza o DataGridView de pizzas após a remoção
                    LoadPizzasGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pizza para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void removerB_Click(object sender, EventArgs e) //Parte das bebidas aqui
        {
            if (dataGridBebidasR.SelectedRows.Count > 0)
            {
                int bebidaId = Convert.ToInt32(dataGridBebidasR.SelectedRows[0].Cells["bebida_id"].Value);

                // Abre o formulário de remoção de bebida com o Id da bebida selecionada
                RemoveBebida removeBebidaForm = new RemoveBebida(bebidaId);
                if (removeBebidaForm.ShowDialog() == DialogResult.OK)
                {
                    // Atualiza o DataGridView de bebidas após a remoção
                     LoadBebidasGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma bebida para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
