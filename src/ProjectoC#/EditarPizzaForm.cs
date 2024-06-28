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
    public partial class EditarPizzaForm : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        private int pizzaId;
        

        public EditarPizzaForm(int id)
        {
            InitializeComponent();
            pizzaId = id;
        }

        public class Pizza
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }


        private void EditarPizzaForm_Load(object sender, EventArgs e)
        {
            // Carrega os detalhes da pizza com base no Id
            Pizza pizza = ObterPizzaPorId(pizzaId);

            // Preenche os campos no formulário de edição
            txtNomeP.Text = pizza.Nome;
            txtPrecoP.Text = pizza.Preco.ToString();
        }

        private Pizza ObterPizzaPorId(int id)
        {
            Pizza pizza = new Pizza();

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pizza.Nome = reader["nome"].ToString();
                        pizza.Preco = Convert.ToDecimal(reader["preco"]);
                    }
                }
            }

            return pizza;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string novoNome = txtNomeP.Text;
            decimal novoPreco;

            if (decimal.TryParse(txtPrecoP.Text, out novoPreco))
            {
                AtualizarPizza(pizzaId, novoNome, novoPreco);
                MessageBox.Show("Pizza atualizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, insira um preço válido.");
            }

        }

        private void AtualizarPizza(int id, string nome, decimal preco)
        {

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "UPDATE sabor_pizzas SET nome = @Nome, preco = @Preco WHERE sabor_id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Preco", preco);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
