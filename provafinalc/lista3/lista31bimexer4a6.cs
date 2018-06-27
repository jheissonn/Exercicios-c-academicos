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
    public partial class lista31bimexer4a6 : Form
    {
        public lista31bimexer4a6()
        {
            InitializeComponent();
        }

        private void buttonExer4_Click(object sender, EventArgs e)
        {
            double publico,total;
            publico = (double)numericUpDownPublico.Value;

            total = (10 * (publico * 0.1)) + (20 * (publico * 0.5)) +
                (50 * (publico * 0.3)) + (100 * (publico * 0.1));
            MessageBox.Show("O preço total ficou em : " + total.ToString("f2"),"EXERCICIO 4");


        }

        private void buttonExer5_Click(object sender, EventArgs e)
        {
            Double salario, tempo;
            salario = (double)numericUpDownSalario.Value;
            tempo = (double)numericUpDownTempo.Value;

            if (tempo <= 1)
            { MessageBox.Show("NÃO Tem gratificação");
                return;
            }
            if (tempo <= 10)
            {
                salario = salario * 0.1;
                MessageBox.Show("A gratificação é de :" + salario.ToString("f2"));
            }
            else {
                salario = salario * 0.25;
                MessageBox.Show("A gratificação é de :" + salario.ToString("f2"));

            }


        }

        private void buttonTecnico_Click(object sender, EventArgs e)
        {
            double salario;
            salario = (double)numericUpDown1.Value;
            salario = salario * 1.5;
            MessageBox.Show("O seu novo salário é: "+salario.ToString("f2"));
        }

        private void buttonGerente_Click(object sender, EventArgs e)
        {
            double salario;
            salario = (double)numericUpDown1.Value;
            salario = salario * 1.3;
            MessageBox.Show("O seu novo salário é: " + salario.ToString("f2"));
        }

        private void buttonOutros_Click(object sender, EventArgs e)
        {
            double salario;
            salario = (double)numericUpDown1.Value;
            salario = salario * 1.2;
            MessageBox.Show("O seu novo salário é: " + salario.ToString("f2"));
        }

        private void lista31bimexer4a6_Load(object sender, EventArgs e)
        {

        }
    }
}
