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


    public partial class RemoveBebida : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);
        private int bebidaId;
        public RemoveBebida(int id)
        {
            InitializeComponent();
            bebidaId = id;
        }
        private void RemoverBebida(int id)
        {
            string query = "DELETE FROM Bebida WHERE bebida_id = @Id";
            using (SqlConnection connection = new SqlConnection(stringconexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        private Tuple<string, decimal> ObterNomeEPrecoBebida(int id)
        {
            string query = "SELECT nomebev, preco FROM Bebida WHERE bebida_id = @Id";
            using (SqlConnection connection = new SqlConnection(stringconexao))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string nomeBebida = reader["nomebev"].ToString();
                    decimal precoBebida = Convert.ToDecimal(reader["preco"]);
                    return new Tuple<string, decimal>(nomeBebida, precoBebida);
                }
            }
            return null;
        }

        private void removerb_Click(object sender, EventArgs e)
        {

        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveBebida_Load(object sender, EventArgs e)
        {
            // Obter o nome e o preço da bebida
            Tuple<string, decimal> nomeEPreco = ObterNomeEPrecoBebida(bebidaId);

            if (nomeEPreco != null)
            {
                string nomeBebida = nomeEPreco.Item1;
                decimal precoBebida = nomeEPreco.Item2;

                // Exibir mensagem de confirmação
                var result = MessageBox.Show($"Tem certeza que deseja remover a bebida '{nomeBebida}' com preço €{precoBebida:F2}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remover a bebida
                    RemoverBebida(bebidaId);
                    MessageBox.Show("Bebida removida com sucesso!");
                    this.DialogResult = DialogResult.OK;  // Define o resultado do diálogo como OK
                    this.Close();  // Fecha o formulário após a remoção
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar informações da bebida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
