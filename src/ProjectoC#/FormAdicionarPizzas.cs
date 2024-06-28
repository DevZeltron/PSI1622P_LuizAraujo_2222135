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
    public partial class FormAdicionarPizzas : Form
    {
        private string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";


        public FormAdicionarPizzas()
        {
            InitializeComponent();
        }

        private void salvarbtn_Click(object sender, EventArgs e)
        {
            string nome = saborPtxt.Text;
            decimal preco = decimal.Parse(precotxt.Text); // Validar a entrada na aplicação real

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();

                    string sql = "INSERT INTO sabor_pizzas (nome, preco) VALUES (@nome, @preco)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@preco", preco);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Nova pizza adicionada com sucesso. Linhas afetadas: {rowsAffected}");
                    }
                }

                // Fechar o formulário com DialogResult OK para indicar sucesso
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar nova pizza: {ex.Message}");
            }

        }
    }
}
