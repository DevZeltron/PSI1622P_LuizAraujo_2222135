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
    public partial class EditarBebidaForm : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);


        public class editaradm
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }
        private int bebidaId;
        public EditarBebidaForm(int Id)
        {
            InitializeComponent();
            bebidaId = Id;
        }

        public EditarBebidaForm()
        {
        }

        private editaradm ObterBebidaPorId(int id)
        {
            editaradm bebida = new editaradm();

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT nome, preco FROM Bebidas WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bebida.Nome = reader["nomebev"].ToString();
                        bebida.Preco = Convert.ToDecimal(reader["preco"]);
                    }
                }
            }

            return bebida;
        }

        private void AtualizarBebida(int id, string nome, decimal preco)
        {
            string connectionString = "sua_connection_string_aqui";
            string query = "UPDATE Bebidas SET nomebev = @Nome, preco = @Preco WHERE bebida_id = @Id";

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

        private void salvarbebida_Click(object sender, EventArgs e)
        {
           
            string novoNome = txtNomeb.Text;
            decimal novoPreco;

            if (decimal.TryParse(txtPrecob.Text, out novoPreco))
            {
                AtualizarBebida(bebidaId, novoNome, novoPreco);
                MessageBox.Show("Bebida atualizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, insira um preço válido.");
            }
        }

        private void EditarBebidaForm_Load(object sender, EventArgs e)
        {
            // Carrega os detalhes da bebida com base no Id
            editaradm bebida = ObterBebidaPorId(bebidaId);

            // Preenche os campos no formulário de edição
            txtNomeb.Text = bebida.Nome;
            txtPrecob.Text = bebida.Preco.ToString();
        }
    }
}
