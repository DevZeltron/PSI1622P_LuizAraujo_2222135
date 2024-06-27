using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoC_
{
    internal class pepperoni
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public pepperoni(string conexao)
        {
            stringconexao = conexao;
        }

        public void CarregarPrecoPepperoni(int saborId, Label label)
        {
            string query = "SELECT nome, preco FROM sabor_pizzas WHERE sabor_id = @SaborId";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SaborId", saborId);

                        StringBuilder sb = new StringBuilder();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                decimal preco = (decimal)reader["preco"];
                                sb.AppendLine($"{nome}: € {preco:F2}");
                            }
                            else
                            {
                                sb.AppendLine("Pizza não encontrada.");
                            }
                        }

                        // Atualiza a label com o preço da pizza
                        label.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o preço da pizza: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
