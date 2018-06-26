using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provafinalc
{
    public partial class lista2bim117a19 : Form
    {
        public lista2bim117a19()
        {
            InitializeComponent();
        }

        private void buttonexer17_Click(object sender, EventArgs e)
        {
            double salario, total,final;
            salario = (double)numericUpDownsalario.Value;
            total = (double)numericUpDowntotaldeVendas.Value;
            if (total > 1500)
            {
                final = ((total - 1500) * 0.05) + (1500 * 0.03);
                final = final + salario;
                MessageBox.Show("o salário final é R$: " + final.ToString("f2"));
            }
            else
            {
                final = salario + (total * 0.03);

            }
        }

        private void buttonexer18_Click(object sender, EventArgs e)
        {
            int golA, golB;
            string timeA, timeB;
            timeA = textBoxTimeA.Text;
            timeB = textBoxTimeB.Text;

            golA = (int)numericUpDownGolsA.Value;
            golB = (int)numericUpDowngolsB.Value;
            if (golA == golB)
            {

                MessageBox.Show("o jogo acabou em empate","empate");

            }

            if (golA > golB)
            {
                MessageBox.Show("o time vencedor é time " + timeA.ToString());
            }
            else
            {
                MessageBox.Show("o time vencedor é time " + timeB.ToString());
            }

        }

        private void buttonAlcool_Click(object sender, EventArgs e)
        {
            double litros,pagar=0;
            litros = (double)numericUpDownLitros.Value;
            if (litros > 20)
            {
                pagar = (litros - 20) * (2.9 - (2.9 * 0.05));
                pagar = pagar + (20 * (2.9 - (2.9 * 0.03)));
                MessageBox.Show("valor total é: R$ " + pagar.ToString("f2"), "ALCOOL");

            }
            else {

                pagar = (20 * (2.9 - (2.9 * 0.03)));
                MessageBox.Show("valor total é: R$ " + pagar.ToString("f2"), "ALCOOL");
            }
        }

        private void buttonGasolina_Click(object sender, EventArgs e)
        {
            double litros, pagar = 0;
            litros = (double)numericUpDownLitros.Value;
            if (litros > 20)
            {
                pagar = (litros - 20) * (3.3 - (3.3 * 0.06));
                pagar = pagar + (20 * (3.3 - (3.3 * 0.04)));
                MessageBox.Show("valor total é: R$ " + pagar.ToString("f2"), "GASOLINA");

            }
            else
            {

                pagar = (20 * (3.3 - (3.3 * 0.04)));
                MessageBox.Show("valor total é: R$ " + pagar.ToString("f2"), "GASOLINA");

            }

        }
    }
}
