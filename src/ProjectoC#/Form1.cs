using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;

namespace ProjectoC_
{
    public partial class Form1 : Form
    {

        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        
        public string NomeUtilizador { get; set; }
        public string Password { get; set; }

        public Form1()
        {
            InitializeComponent();
            // createacclink.LinkClicked += new LinkLabelLinkClickedEventHandler(createacclink_LinkClicked);
        }

        /* private void button1_Click(object sender, EventArgs e)
         {

         }*/ //nothing haha ignorar 

        private void entrarbtn_Click(object sender, EventArgs e)
        {
            NomeUtilizador = namelogin.Text.Trim();
            Password = passlogin.Text.Trim();

            if (string.IsNullOrEmpty(NomeUtilizador) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador e a palavra-passe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (VerifyLogin(NomeUtilizador, Password))
            {
                MessageBox.Show("Login bem-sucedido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou palavra-passe incorretos. Por favor, tente novamente ou crie uma conta.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyLogin(string username, string password)
        {

            string query = "SELECT COUNT(1) FROM loginn WHERE username = @NomeUtilizador AND password = @Password";
            if (username == "admin")
            {
                AdminPanel admpanel =   new AdminPanel();
                admpanel.Show();
                try
                {
                    using (SqlConnection connection = new SqlConnection(stringconexao))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NomeUtilizador", username);
                            command.Parameters.AddWithValue("@Password", password);

                            int userCount = (int)command.ExecuteScalar();
                            return userCount == 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {

                try
                {
                    using (SqlConnection connection = new SqlConnection(stringconexao))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@NomeUtilizador", username);
                            command.Parameters.AddWithValue("@Password", password);

                            int userCount = (int)command.ExecuteScalar();
                            return userCount == 1;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        private void createacclink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            criacaoconta form = new criacaoconta();
            form.Show();
        }
    }
}