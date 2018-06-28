using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provafinalc.lista2
{
    public partial class lista21bimexer14a16 : Form
    {
        public lista21bimexer14a16()
        {
            InitializeComponent();
        }

        private void buttonsalario_Click(object sender, EventArgs e)
        {
            double salario, percentual, reajuste;
            salario = (double)numericUpDownsalario.Value;
            percentual = (double)numericUpDownpercentual.Value;

            reajuste = ((percentual / 100) * salario) + salario;
            MessageBox.Show("o novo salário é " + reajuste.ToString("f2"),"exercicio2");
                             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double quanticarros, totaldeVendas, salafixo, ganhaPorCarro,salariofinal;
            quanticarros = (double)numericUpDownQuantoscarros.Value;
            totaldeVendas = (double)numericUpDownTotaldevendas.Value;
            salafixo = (double)numericUpDownsalariofixo.Value;
            ganhaPorCarro = (double)numericUpDownGanhaPorCarro.Value;
            salariofinal = salafixo +((quanticarros * ganhaPorCarro) + (totaldeVendas * 0.05));
            MessageBox.Show("O salario final é R$: " + salariofinal.ToString("f2"));
            
        }

        private void buttonexer16_Click(object sender, EventArgs e)
        {
            double hrasTrabalhadas, valorHras,salariof;
            hrasTrabalhadas = (double)numericUpDownHras.Value;
            valorHras = (double)numericUpDownValorPorHra.Value;

            if (hrasTrabalhadas > 40)
            {
                salariof = ((hrasTrabalhadas - 40) * (valorHras * 1.5)) + (40 * valorHras);
                MessageBox.Show("o salário final é " + salariof.ToString("f2") + "R$");
            }
            else
            {
                salariof = hrasTrabalhadas* valorHras;
                MessageBox.Show("o salário final é " + salariof.ToString("f2") + "R$");
            }
        }
    }
}
