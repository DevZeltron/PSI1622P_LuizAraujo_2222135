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
    public partial class Formmoney : Form
    {
        private decimal totalFinal;
        public Formmoney()
        {
            InitializeComponent();
            this.totalFinal = totalFinal;
        }

        private void moneybtn_Click(object sender, EventArgs e)
        {
            // Captura o valor digitado pelo usuário para pagamento em dinheiro
            if (!decimal.TryParse(montantetxt.Text, out decimal valorDinheiro))
            {
                MessageBox.Show("Valor inválido. Por favor, insira um valor numérico.");
                return;
            }

            // Verifica se o valor em dinheiro é maior, igual ou menor que o total a pagar
            if (valorDinheiro > totalFinal)
            {
                // Calcula o troco
                decimal troco = totalFinal - valorDinheiro;
                MessageBox.Show($"Pagamento em dinheiro realizado com sucesso!\nTotal pago: {valorDinheiro:F2}\nTroco: {troco:F2}");

                

                this.Close();
            }
            else if (valorDinheiro == totalFinal)
            {
                MessageBox.Show($"Pagamento em dinheiro realizado com sucesso!\nTotal pago: {valorDinheiro:F2}\nNão há troco.");

               
                this.Close();
            }
            else
            {
                MessageBox.Show($"Falta dinheiro! Valor pago: {valorDinheiro:F2}, Total a pagar: {totalFinal:F2}");
            }

        }
    }
}
