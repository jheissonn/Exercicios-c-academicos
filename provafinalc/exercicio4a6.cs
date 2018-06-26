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
    public partial class exercicio4a6 : Form
    {
        public exercicio4a6()
        {
            InitializeComponent();
        }

        private void buttonporcentagem_Click(object sender, EventArgs e)
        {
            int total, brancos, nulos, validos;
            int porcebrancos, porcenulos, porcevalidos;

            total = (int)numericUpDowntotaleleitores.Value;
            brancos = (int)numericUpDownvotosbrancos.Value;
            nulos = (int)numericUpDownvotosnulos.Value;
            validos = (int)numericUpDownvotosvalidos.Value;
            if (total == 0)
                return;
            porcebrancos = (brancos * 100) / total;
            porcenulos = (nulos * 100) / total;
            porcevalidos = (validos * 100) / total;


            MessageBox.Show("A porcentagem de votos brancos é de: "+porcebrancos.ToString()+"% "+
                " A porcentagem de votos nulos é de: " + porcenulos.ToString() + "% "+
                " A porcentagem de votos validos é de: " + porcevalidos.ToString() + "% ","botão porcentagem");

        }

        private void buttonreajuste_Click(object sender, EventArgs e)
        {
            double salario, salarioajustado, reajuste;
            salario = (double)numericUpDownsalario.Value;
            reajuste = (double)numericUpDownreajuste.Value;

            salarioajustado = ((salario * reajuste) / 100) + salario;
            MessageBox.Show("o salario reajustado é: " + salarioajustado.ToString("f2") + "R$", "botao reajuste");
        }

        private void buttoncalculapreco_Click(object sender, EventArgs e)
        {
            double precoajustado, preco;
            preco = (double)numericUpDowncustofabrica.Value;
            precoajustado = (preco * 1.28) + 1.45;
            MessageBox.Show("o preço ajustado é de: " + precoajustado.ToString("f2") + "R$", "botão calcula");
        }
    }
}
