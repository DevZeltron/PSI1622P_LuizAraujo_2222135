using Microsoft.Data.SqlClient;

namespace ProjectoC_
{
    public partial class Form1 : Form
    {

        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=pizzaria_raimundo;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public Form1()
        {
            InitializeComponent();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {

        }*/ //nothing haha

        private void entrarbtn_Click(object sender, EventArgs e)
        {

        }


    }
}