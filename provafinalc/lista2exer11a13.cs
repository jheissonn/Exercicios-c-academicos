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
    public partial class lista2exer11a13 : Form
    {
        public lista2exer11a13()
        {
            InitializeComponent();
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {

            double a, b, c, p, area;
            a = (double)numericUpDownValordea.Value;
            b = (double)numericUpDownValordeB.Value;
            c = (double)numericUpDownValordeC.Value;

            if (((b - c) < a && a < (b + c)) && ((a - c) < b && a < (a + c)) && ((a - b) < c && a < (a + b)))
            {
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                MessageBox.Show("A area do triangulo apresentado é de : " + area + "cm²");

            }
            else
            {
                MessageBox.Show("os valores apresentados não formam um triangulo");
            }
        }

        private void buttonparouimpar_Click(object sender, EventArgs e)
        {
            int numero;
            numero = (int)numericUpDownparouimpar.Value;
            if (numero % 2 == 0)
            {
                MessageBox.Show("o número " + numero.ToString() + "é par");

            }
            else {
                MessageBox.Show("o número " + numero.ToString() + "é impar");
            }
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


            MessageBox.Show("A porcentagem de votos brancos é de: " + porcebrancos.ToString() + "% " +
                " A porcentagem de votos nulos é de: " + porcenulos.ToString() + "% " +
                " A porcentagem de votos validos é de: " + porcevalidos.ToString() + "% ", "botão porcentagem");
        }
    }
}
