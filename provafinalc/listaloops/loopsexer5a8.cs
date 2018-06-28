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
    public partial class loopsexer5a8 : Form
    {
        public loopsexer5a8()
        {
            InitializeComponent();
        }

        private void buttonExer5_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDownImpar.Value % 2 == 1)
                MessageBox.Show("O numeero informado é um numero impar" + numericUpDownImpar.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 1;
            richTextBoxMostrar.Clear();
            int  n = (int)numericUpDownFibonacci.Value;
            for (int i = 0; i < n; i++)
            {
                int temp = a;//guarda o anterior
                a = b;//
                b = temp + b;
                richTextBoxMostrar.AppendText(b.ToString() + Environment.NewLine);

            }
           
        }

        private void buttonExer7_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int inicio,fim;
            inicio = (int)numericUpDownInicio.Value;
            fim = (int)numericUpDownFim.Value;
            for (int i = inicio; i <= fim; i++)
            {
                if (i % 9 == 0)
                richTextBoxMostrar.AppendText(i.ToString() +" É DIVISIVEL POR 9"+ Environment.NewLine); 

            }
        }

        private void buttonExer8_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int inicio, fim,inteiro;
            inteiro = (int)numericUpDownInteiro.Value;
            inicio = (int)numericUpDownInicio.Value;
            fim = (int)numericUpDownFim.Value;
            for (int i = inicio; i <= fim; i++)
            {
                if (i % inteiro == 0)
                    richTextBoxMostrar.AppendText(i.ToString() + " É DIVISIVEL POR "+inteiro.ToString() + Environment.NewLine);

            }
        }
    }
}
