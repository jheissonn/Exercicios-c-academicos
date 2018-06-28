using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provafinalc.lista3
{
    public partial class lista31bimexer10a12 : Form
    {
        public lista31bimexer10a12()
        {
            InitializeComponent();
        }

        private void buttonExer10_Click(object sender, EventArgs e)
        {
            double salario, prestacao;
            salario = (double)numericUpDownSalario.Value;
            prestacao = (double)numericUpDownPrestacao.Value;

            if (prestacao < salario * 0.3)
                MessageBox.Show("O empréstimo pode ser concedido", "CERTO");
            else
                MessageBox.Show("o emprestimo não pode ser concedido", "ERRADO");
        }

        private void buttonExer11_Click(object sender, EventArgs e)
        {
            double a, b, c, p, area;
            string nome=string.Empty;
            a = (double)numericUpDownLadoA.Value;
            b = (double)numericUpDownLadoB.Value;
            c = (double)numericUpDownLadoC.Value;

            if (((b - c) < a && a < (b + c)) && ((a - c) < b && a < (a + c)) && ((a - b) < c && a < (a + b)))
            {
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                if (a == b && b == c)
                    nome = "é um triangulo equilátero";
                if ((a == b && b != c) || (a == c && c != b) || (b == c && c != a))
                    nome = "é um triangulo isósceles";
                if (a != b && b != c && c != a)
                    nome = "é um Triângulo Escaleno";
                MessageBox.Show("A area do triangulo apresentado é de : " + area.ToString() + "cm²"+nome.ToString());


            }

            else
                MessageBox.Show("os valores apresentados não formam um triangulo");



        }

        private void buttonExer12_Click(object sender, EventArgs e)
        {
            string[] meses = new string[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio",
                "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int mes = (int )numericUpDowMeses.Value;
            MessageBox.Show("o mês informado é" + meses[mes].ToString());

        }
    }
}
