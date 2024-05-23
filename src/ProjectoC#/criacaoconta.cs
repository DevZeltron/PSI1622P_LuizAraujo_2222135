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
    public partial class criacaoconta : Form
    {

        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=pizzaria_raimundo;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public string NomeUtilizador { get; set; }
        public string Password { get; set; }

        public criacaoconta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usercria = criaruser.Text.Trim();
            string passcria = criarsenha.Text.Trim();


            if (string.IsNullOrEmpty(usercria) || string.IsNullOrEmpty(passcria))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador e a palavra-passe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(stringconexao))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO criar_user (username_criar, password_criar) VALUES (@username_criar, @password_criar)", connection))
                    {
                        command.Parameters.AddWithValue("@username_criar", usercria);
                        command.Parameters.AddWithValue("@password_criar", passcria);

                        command.ExecuteNonQuery();  // Execute the command
                    }
                }

                MessageBox.Show("Conta criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


       
    
}
