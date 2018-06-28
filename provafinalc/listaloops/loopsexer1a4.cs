using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provafinalc.listaloops
{
    public partial class loopsexer1a4 : Form
    {
        public loopsexer1a4()
        {
            InitializeComponent();
        }

        private void buttoneExer1_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            for (int i = 0; i < 10; i++)
            {
                richTextBoxMostrar.AppendText(i.ToString()+Environment.NewLine);
            }
        }

        private void buttonExer2_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int soma=0;
            for (int i = 0; i < 10; i++)
            {
                soma += i;
                richTextBoxMostrar.AppendText(soma.ToString() + Environment.NewLine);
            }

        }

        private void buttonExer3_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            double expoente, bas,potencia=0;
            expoente = (double)numericUpDownExpoente.Value;
            bas = (double)numericUpDownBase.Value;
            potencia = bas;

            for (int i = 1; i < expoente; i++)
            {
                potencia = potencia * bas;

            }

            richTextBoxMostrar.AppendText("a potência é: " + potencia.ToString());

        }

        private void buttonExer4_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            if ((int)numericUpDownPar.Value % 2 == 0)
                MessageBox.Show("O NUMERO INFORMADO É PAR");
            else
                MessageBox.Show("O NUMERO INFORMADO NÃO É PAR");
        }
    }
}
