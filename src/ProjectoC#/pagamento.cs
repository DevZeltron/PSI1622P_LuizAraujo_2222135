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
    public partial class pagamento : Form
    {
        private List<decimal> precosPizzas;
        private List<decimal> precosBebidas;

        public pagamento()
        {
            InitializeComponent();
        }

        

        

        public pagamento(List<decimal> precosPizzas, List<decimal> precosBebidas)
        {
            InitializeComponent();
            this.precosPizzas = precosPizzas;
            this.precosBebidas = precosBebidas;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal totalPizzas = precosPizzas.Sum();
            decimal totalBebidas = precosBebidas.Sum();
            decimal total = totalPizzas + totalBebidas;

            totalp.Text = $"Total a pagar: € {total:F2}";
        }

        private void pagamento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cardrdnbtn.Checked)
            {
                Formulariocartao formcard = new Formulariocartao();
                formcard.Show();
            }
            else if (moneyrdnbtn.Checked)
            {
                // 1. Calcular o total a ser pago
                decimal totalFinal = 0;
                foreach (decimal precoPizza in precosPizzas)
                {
                    totalFinal += precoPizza;
                }

                foreach (decimal precoBebida in precosBebidas)
                {
                    totalFinal += precoBebida;
                }

                // 2. Obter o valor pago pelo usuário
                string input = Microsoft.VisualBasic.Interaction.InputBox("Insira o valor pago:", "Pagamento em dinheiro", "");
                if (decimal.TryParse(input, out decimal valorPago))
                {
                    // 3. Verificar se o valor pago é suficiente
                    if (valorPago >= totalFinal)
                    {
                        // 4. Calcular o troco
                        decimal troco = valorPago - totalFinal;

                        // 5. Exibir mensagem com o troco
                        MessageBox.Show($"Pagamento realizado com sucesso! Troco: € {troco:F2}");
                    }
                    else
                    {
                        // 6. Informar que falta dinheiro
                        MessageBox.Show("Valor insuficiente. Por favor, insira mais dinheiro.");
                    }
                }
                else
                {
                    // 7. Informar que o valor inserido é inválido
                    MessageBox.Show("Valor inserido inválido. Por favor, insira um valor numérico.");
                }
            }


         }

            private void totalp_Click(object sender, EventArgs e)
            {

            }
     }

}
  
