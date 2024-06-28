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
        private List<decimal> precosBebidas; // Deveria ser inicializada e passada como argumento

        public pagamento(List<decimal> precosPizzas, List<decimal> precosBebidas)
        {
            InitializeComponent();
            this.precosPizzas = precosPizzas;
            this.precosBebidas = precosBebidas; // Recebe a lista de preços das bebidas

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal totalFinal = 0;

            // Somar os preços das pizzas selecionadas
            foreach (decimal precoPizza in precosPizzas)
            {
                totalFinal += precoPizza;
            }

            // Somar os preços das bebidas selecionadas (se houver)
            if (precosBebidas != null)
            {
                foreach (decimal precoBebida in precosBebidas)
                {
                    totalFinal += precoBebida;
                }
            }

            // Exibir o total final no label
            totalp.Text = $"€ {totalFinal:F2}";
        }

        private void pagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
