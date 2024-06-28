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
using static ProjectoC_.EditarPizzaForm;

namespace ProjectoC_
{
    public partial class RemovePizza : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        private int pizzaId;
        public RemovePizza(int id)
        {
            InitializeComponent();
            pizzaId = id;
        }

        private void removerbtn_Click(object sender, EventArgs e)
        {

        }
        
        private void RemoverPizza(int id)
        {
            string query = "DELETE FROM sabor_pizzas WHERE sabor_id = @Id";
            using (SqlConnection connection = new SqlConnection(stringconexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        private Tuple<string, decimal> ObterNomeEPrecoPizza(int id)
        {
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = @Id";
            using (SqlConnection connection = new SqlConnection(stringconexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nome = reader["nome"].ToString();
                    decimal preco = Convert.ToDecimal(reader["preco"]);
                    return new Tuple<string, decimal>(nome, preco);
                }
            }
            return null;
        }
        private void RemovePizza_Load(object sender, EventArgs e)
        {
            // Obter o nome e o preço da pizza
            Tuple<string, decimal> nomeEPreco = ObterNomeEPrecoPizza(pizzaId);

            if (nomeEPreco != null)
            {
                string nomePizza = nomeEPreco.Item1;
                decimal precoPizza = nomeEPreco.Item2;

                // Exibir mensagem de confirmação
                var result = MessageBox.Show($"Tem certeza que deseja remover a pizza '{nomePizza}' com preço €{precoPizza:F2}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remover a pizza
                    RemoverPizza(pizzaId);
                    MessageBox.Show("Pizza removida com sucesso!");
                    this.DialogResult = DialogResult.OK;  // Define o resultado do diálogo como OK
                    this.Close();  // Fecha o formulário
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar informações da pizza.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
