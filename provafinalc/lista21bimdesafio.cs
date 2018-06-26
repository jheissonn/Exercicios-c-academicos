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
    public partial class lista21bimdesafio : Form
    {
        public lista21bimdesafio()
        {
            InitializeComponent();
        }

        private void buttoncrescene_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = (int)numericUpDownnum1.Value;
            num2 = (int)numericUpDownnum2.Value;
            num3 = (int)numericUpDownnum3.Value;

            if (num1 < num2 && num2 < num3)
            {
                MessageBox.Show("a ordem crescente é: " + num1.ToString() +" "+ num2.ToString() +" "+ num3.ToString());

            }
            if (num1 < num3 && num3 < num2)
            {
                MessageBox.Show("a ordem crescente é: " + num1.ToString() +" "+ num3.ToString() + " " + num2.ToString());

            }
            if (num2 < num1 && num1 < num3)
            {
                MessageBox.Show("a ordem crescente é: " + num2.ToString() + " " + num1.ToString() + " " + num3.ToString());

            }
            if (num2 < num3 && num3 < num1)
            {
                MessageBox.Show("a ordem crescente é: " + num2.ToString() + " " + num3.ToString() + " " + num1.ToString());

            }
            if (num3 < num1 && num1 < num2)
            {
                MessageBox.Show("a ordem crescente é: " + num3.ToString() + " " + num1.ToString() + " " + num2.ToString());

            }
            if (num3 < num2 && num2 < num1)
            {
                MessageBox.Show("a ordem crescente é: " + num3.ToString() + " " + num2.ToString() + " " + num1.ToString());

            }
        }
    }
}
