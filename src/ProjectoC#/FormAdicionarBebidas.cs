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
    public partial class FormAdicionarBebidas : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public FormAdicionarBebidas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = nomeBtxt.Text;
            decimal preco = decimal.Parse(precotxt.Text); // Validar a entrada na aplicação real

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();

                    string sql = "INSERT INTO Bebida (nomebev, preco) VALUES (@nomebev, @preco)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nomebev", nome);
                        command.Parameters.AddWithValue("@preco", preco);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Nova bebida adicionada com sucesso. Linhas afetadas: {rowsAffected}");
                    }
                }

                // Fechar o formulário com DialogResult OK para indicar sucesso
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar nova bebida: {ex.Message}");
            }
        }
    }
}
