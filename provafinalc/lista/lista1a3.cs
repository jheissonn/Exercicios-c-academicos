using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provafinalc.lista
{
    public partial class lista1a3 : Form
    {
        public lista1a3()
        {
            InitializeComponent();
        }

        private void buttonmostrasucessor_Click(object sender, EventArgs e)
        {
            int sucessor = (int)numericUpDownsucessor.Value;
            MessageBox.Show("O sucessor do numero informado é: "+(sucessor - 1).ToString(),"botão sucessor");
        }

        private void buttoncalculaarea_Click(object sender, EventArgs e)
        {
            double ladoa, ladob, area;
            ladoa = (double)numericUpDownbase.Value;
            ladob = (double)numericUpDownaltura.Value;
            area = ladob * ladoa;
            MessageBox.Show("A area do retangulo informado é: "+area.ToString()+"cm2","botão area");           
        }

        private void buttonidade_Click(object sender, EventArgs e)
        {
            int idade,dias;
            idade = (int)numericUpDownidade.Value;
            dias = idade * 365;
            MessageBox.Show("Sua idade em dias é: "+dias.ToString(), "Botão dias");
        }
    }
}
