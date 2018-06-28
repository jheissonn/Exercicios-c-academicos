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
    public partial class lista31bimexer13a15 : Form
    {
        public lista31bimexer13a15()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxSenha.Text == "batatafrita")
            {
                MessageBox.Show("parabens senha correta");
            }
            else
            {
                MessageBox.Show("senha incorreta tente novamente");
            }
        }

        private void buttonExer14_Click(object sender, EventArgs e)
        {
            double compras;
            compras = (double)numericUpDownCompras.Value;
            if (compras < 10)
                MessageBox.Show("o valor da venda é de: " + (compras * 1.7).ToString());
            if (compras < 30 && compras > 10 )
                MessageBox.Show("o valor da venda é de: " + (compras * 1.5).ToString());
            if (compras < 50 && compras > 30)
                MessageBox.Show("o valor da venda é de: " + (compras * 1.4).ToString());
            if (compras > 50)
                MessageBox.Show("o valor da venda é de: " + (compras * 1.3).ToString());
        }

        private void buttonExer15_Click(object sender, EventArgs e)
        {
            double salario = (double)numericUpDownSalario.Value;
            if (salario <= 600)
                MessageBox.Show("O novo salário é: " + (salario * 1.3).ToString("f2"));
            if (salario > 600 && salario < 1100)
                MessageBox.Show("O novo salário é: " + (salario * 1.25).ToString("f2"));
            if (salario > 1100 && salario < 2400)
                MessageBox.Show("O novo salário é: " + (salario * 1.2).ToString("f2"));
            if (salario > 2400 && salario < 3550)
                MessageBox.Show("O novo salário é: " + (salario * 1.15).ToString("f2"));
            if (salario > 3550)
                MessageBox.Show("O novo salário é: " + (salario * 1.1).ToString("f2"));
        }

        private void buttonExer16_Click(object sender, EventArgs e)
        {
            double poluicao = (double)numericUpDownPoluicao.Value;
            if (poluicao > 0.05 && poluicao < 0.25)
                MessageBox.Show("Aceitavel");
            if (poluicao > 0.25 && poluicao < 0.4)
                MessageBox.Show("São intimadas as industriar do grupoo 1");
            if (poluicao > 0.3 && poluicao < 0.5)
                MessageBox.Show("São intimadas as industriar do grupoo 1 e 2");
            if (poluicao > 0.3 && poluicao < 0.6)
                MessageBox.Show("São intimadas as industriar do grupoo 1 , 2 E 3");
            if (poluicao > 0.5 )
                MessageBox.Show("AS ATIVIDADES ESTÃO ENCERRADAS");
        }
    }
}
