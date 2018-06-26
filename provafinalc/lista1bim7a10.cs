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
    public partial class lista1bim7a10 : Form
    {
        public lista1bim7a10()
        {
            InitializeComponent();
        }

        private void buttoncalcula_Click(object sender, EventArgs e)
        {
            double a, b, c, delta,x1,x2;
            a = (double)numericUpDownvalordea.Value;
            b = (double)numericUpDownvalordeb.Value;
            c = (double)numericUpDownvalordec.Value;

            if (a == 0)
            {
                MessageBox.Show("não é possivel calcular ", "ERROO");
                return;
            }
            delta = (b * b) - (4 * a * c);

            if (delta < 0) {

                MessageBox.Show("não é possivel calcular dentro de R ","ERROO");
                return;
            }
            x1 = (-(b) + Math.Sqrt(delta)) / (2 * 0);
            x2 = (-(b) - Math.Sqrt(delta)) / (2 * 0);
            MessageBox.Show("o valor de x1 é " + x1.ToString()+"o valor de  x2 é "+x2.ToString());
        }

        private void buttonIdade_Click(object sender, EventArgs e)
        {
            int idade;
            idade =(int)numericUpDownIdade.Value;
            if (idade <= 7)
            {
                MessageBox.Show("o nadador é classificado em infantil A ","exercicio 8");
                return;
            }
            if (idade <= 10)
            {
                MessageBox.Show("o nadador é classificado em infantil B ", "exercicio 8");
                return;
            }
            if (idade <= 13)
            {
                MessageBox.Show("o nadador é classificado em juvenil A ", "exercicio 8");
                return;
            }
            if (idade <= 17)
            {
                MessageBox.Show("o nadador é classificado em juvenil B", "exercicio 8");
                return;
            }
            if (idade >= 18)
            {
                MessageBox.Show("o nadador é classificado em adulto", "exercicio 8");
                return;
            }
        }

        private void buttonMaior_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            num1 = (int)numericUpDownvalor1.Value;
            num2 = (int)numericUpDownvalor2.Value;
            num3 = (int)numericUpDownvalor3.Value;

            if (num1 > num2 && num1 > num3)
            {
                MessageBox.Show("o maior número é " + num1.ToString(),"exercicio 9");
                return;
            }
            else if (num2 > num3)
            {
                MessageBox.Show("o maior número é " + num2.ToString(), "exercicio 9");
                return;
            }
            else
            {
                MessageBox.Show("o maior número é " + num3.ToString(), "exercicio 9");
                return;
            }

        }

        private void buttonMenor_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            num1 = (int)numericUpDownvalor1.Value;
            num2 = (int)numericUpDownvalor2.Value;
            num3 = (int)numericUpDownvalor3.Value;

            if (num1 < num2 && num1 < num3)
            {
                MessageBox.Show("o menor número é " + num1.ToString(), "exercicio 9");
                return;
            }

            if (num2 < num3)
            {
                MessageBox.Show("o menor número é " + num2.ToString(), "exercicio 9");
                return;
            }
            else
            {
                MessageBox.Show("o menor número é " + num3.ToString(), "exercicio 9");
                return;
            }

        }
    }
}
