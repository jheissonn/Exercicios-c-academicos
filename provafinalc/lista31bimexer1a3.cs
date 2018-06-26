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
    public partial class lista31bimexer1a3 : Form
    {
        public lista31bimexer1a3()
        {
            InitializeComponent();
        }

        private void buttonrazao_Click(object sender, EventArgs e)
        {
            double primeiro, ultimo, razao,soma,n;
            primeiro = (double)numericUpDownprimeirotermo.Value;
            ultimo = (double)numericUpDownultimotermo.Value;
            razao = (double)numericUpDownrazao.Value;
            n = (ultimo - primeiro - (razao*(-1))) / razao;
            soma = ((primeiro + ultimo) * n) / 2;

            MessageBox.Show("a soma dos termos é " + soma.ToString(), "exercicio 1");
        }
    }
}
