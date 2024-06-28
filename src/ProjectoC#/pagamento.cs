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
        public pagamento()
        {
            InitializeComponent();
        }

        private List<decimal> precosPizzas;
        private List<decimal> precosBebidas;

        public pagamento(List<decimal> precosPizzas, List<decimal> precosBebidas)
        {
            InitializeComponent();
            this.precosPizzas = precosPizzas;
            this.precosBebidas = precosBebidas;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal totalFinal = 0;

            foreach (decimal precoPizza in precosPizzas)
            {
                totalFinal += precoPizza;
            }

            foreach (decimal precoBebida in precosBebidas)
            {
                totalFinal += precoBebida;
            }

            totalp.Text = $"€ {totalFinal:F2}";
        }

        private void pagamento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cardrdnbtn.Checked)
            {

            }
            else if (moneyrdnbtn.Checked)
            {

            }


         }

            private void totalp_Click(object sender, EventArgs e)
            {

            }
     }

}
  
