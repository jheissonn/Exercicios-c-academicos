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
    public partial class loopsexer9a12 : Form
    {
        public loopsexer9a12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guarda = 0, conta = 0;
            for (int i = 500; i >= 20; i = i - 20)
            {
                if (guarda < 26)
                {
                    guarda = guarda + 2;
                }
                conta = (i / guarda) + conta;



                richTextBoxMostrar.AppendText(conta.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);

            }
        }

        private void buttonExer10_Click(object sender, EventArgs e)
        {
            int primo, contador = 0;
            primo = (int)numericUpDownprimo.Value;

            for (int i = primo; i >= 1; i--)
            {
                if (primo % i == 0)
                {
                    contador = contador + 1;
                }

            }
            if (contador == 2)
            {
                MessageBox.Show("o numero : " + primo.ToString() + " é primo");
            }
            else
            {
                MessageBox.Show("o numero : " + primo.ToString() + " não é primo");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float quantidade, guarda = 0;
            quantidade = (int)numericUpDownGuardan.Value;
            for (int i = 1; i <= quantidade; i++)
            {
                guarda = (quantidade / (quantidade + 1)) + guarda;

                richTextBoxMostrar.AppendText(guarda.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);
            }
        }
    }
}
