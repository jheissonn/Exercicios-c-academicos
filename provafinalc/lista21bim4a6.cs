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
    public partial class lista21bim4a6 : Form
    {
        public lista21bim4a6()
        {
            InitializeComponent();
        }

        private void buttonsalario_Click(object sender, EventArgs e)
        {
            int horas, hraExtra=0, salario;
            horas = (int)numericUpDownHrastrabalhadas.Value;

            if (horas > 50)
            {
                hraExtra = horas - 50;
                salario = 500 + (hraExtra * 20);
                MessageBox.Show("o numero de horas extras é: " + hraExtra.ToString() + "o salário é: R$ " + salario.ToString("f2"),"botão salário");

            }
            else
            {
                salario = horas * 10;
                MessageBox.Show("o numero de horas extras é: " + hraExtra.ToString() + "o salário é: R$ " + salario.ToString("f2"), "botão salário");

            }
        }

        private void buttonexericio5_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3,media;
            nota1 = (double)numericUpDownnota1.Value;
            nota2 = (double)numericUpDownota2.Value;
            nota3 = (double)numericUpDownnota3.Value;
            media = (nota1 + nota2 + nota3 )/ 3;
            MessageBox.Show("A média do aluno é: " + media.ToString(),"exercicio 5");
        }

        private void buttonexer6_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;
            nota1 = (double)numericUpDownnota1.Value;
            nota2 = (double)numericUpDownota2.Value;
            nota3 = (double)numericUpDownnota3.Value;
            media = (nota1 * 0.2) + (nota2 * 0.3) + (nota3 * 0.5);
            MessageBox.Show("A média do aluno é: " + media.ToString(), "exercicio 6");
        }
    }
}
