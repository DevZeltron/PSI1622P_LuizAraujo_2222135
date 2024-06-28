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

        private int pizzaId;

        public EditarPizzaForm(int id)
        {
            InitializeComponent();
            pizzaId = id;
        }

        private void EditarPizzaForm_Load(object sender, EventArgs e)
        {
            // Carrega os detalhes da pizza com base no Id
            editaradm pizza = ObterPizzaPorId(pizzaId); // Implemente este método para obter os detalhes da pizza do banco de dados

            // Preenche os campos no formulário de edição
            txtNome.Text = pizza.Nome;
            txtPreco.Text = pizza.Preco.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Salva as alterações feitas na pizza
            string novoNome = txtNome.Text;
            decimal novoPreco = Convert.ToDecimal(txtPreco.Text);

            // Atualiza a pizza no banco de dados
            AtualizarPizzaNoBancoDeDados(pizzaId, novoNome, novoPreco); // Implemente este método para atualizar a pizza no banco de dados

            MessageBox.Show("Pizza atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
