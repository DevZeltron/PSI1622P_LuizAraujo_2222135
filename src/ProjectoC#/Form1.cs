using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;

namespace ProjectoC_
{
    public partial class Form1 : Form
    {

        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=pizzaria_raimundo;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public Form1()
        {
            InitializeComponent();
            // createacclink.LinkClicked += new LinkLabelLinkClickedEventHandler(createacclink_LinkClicked);
        }

        /* private void button1_Click(object sender, EventArgs e)
         {

         }*/ //nothing haha ignorar kkkkk

        private void entrarbtn_Click(object sender, EventArgs e)
        {
            string nomeuser = namelogin.Text.Trim();
            string passworduser = passlogin.Text.Trim();

            if (string.IsNullOrEmpty(nomeuser) || string.IsNullOrEmpty(passworduser))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador e a palavra-passe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringconexao))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO user_login (username, passwordlogin) VALUES (@username, @passwordlogin)", connection))
                {
                    command.Parameters.AddWithValue("@Name", nomeuser);
                    command.Parameters.AddWithValue("@Password", passworduser);

                }
            }

            MessageBox.Show("Login efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createacclink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            criacaoconta form = new criacaoconta();
            form.Show();
        }
    }
}