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
    public partial class lista31bimexer7a9 : Form
    {
        public lista31bimexer7a9()
        {
            InitializeComponent();
        }

        private void buttonExer7_Click(object sender, EventArgs e)
        {
            double nota1,nota2,nota3, media;
            nota1 = (double)numericUpDownNota1.Value;
            nota2 = (double)numericUpDownNota2.Value;
            nota3 = (double)numericUpDownNota3.Value;
            media = (nota1 + nota2 + nota3) / 3;
            if (media < 80)
                MessageBox.Show("O aluno: " + textBoxNomeexer7.Text.ToString() + " Está reprovado");
            else
                MessageBox.Show("O aluno: " + textBoxNomeexer7.Text.ToString() + " Está aprovado");
        }

        private void buttonExer8_Click(object sender, EventArgs e)
        {
            double numero;
            numero = (double)numericUpDownExer8.Value;
            if (numero == 0)
                MessageBox.Show("O numero informado: " + numero.ToString() + " É NULO");
            if (numero < 0)
             MessageBox.Show("O numero informado: " + numero.ToString() + " É NEGATIVO");
            if (numero > 0)
                MessageBox.Show("O numero informado: " + numero.ToString() + " É POSITIVO");
        }

        private void buttonExer9_Click(object sender, EventArgs e)
        {
            int numero;
            numero = (int)numericUpDownExer9.Value;

            if (numero % 5 == 0)
                MessageBox.Show("O numero informado: " + numero.ToString() + " É DIVISIVEL POR 5");
            else
                MessageBox.Show("O numero informado: " + numero.ToString() +  " NÃO É DIVISIVEL POR 5");

        }
    }
}
