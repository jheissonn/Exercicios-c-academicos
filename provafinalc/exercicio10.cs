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
    public partial class exercicio10 : Form
    {
        public exercicio10()
        {
            InitializeComponent();
        }

        private void buttoncalcula_Click(object sender, EventArgs e)
        {
            double calcula;
            calcula = (Math.Sqrt((double)(((numericUpDownlex2.Value - numericUpDownlex1.Value) *
                (numericUpDownlex2.Value - numericUpDownlex1.Value)) +
                ((numericUpDownley2.Value - numericUpDownley1.Value) *
                (numericUpDownley2.Value - numericUpDownley1.Value)))));
            MessageBox.Show("A distancia entre os dois ponto é " + calcula.ToString(),"botão mostra" +
                "");
        }
    }
}
