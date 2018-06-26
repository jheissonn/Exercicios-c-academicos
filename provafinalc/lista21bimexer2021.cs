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
    public partial class lista21bimexer2021 : Form
    {
        public lista21bimexer2021()
        {
            InitializeComponent();
        }

        private void buttonexer20_Click(object sender, EventArgs e)
        {
            int homemA, homemB, mulherA, mulherB,conta,conta1;
            homemA = (int)numericUpDownIdadehomemA.Value;
            homemB = (int)numericUpDownIdadeHomemB.Value;
            mulherA = (int)numericUpDownIdadeMulherA.Value;
            mulherB = (int)numericUpDownIdadeMulherB.Value;
            if (homemA > homemB)
            {
                if (mulherA < mulherB)
                {
                    conta = mulherA + homemA;
                    conta1 = mulherB * homemB;

                    MessageBox.Show("soma do homem mais velho e mulher mais nova é " + conta.ToString() + "o produto do homem mais novo e da mulher mais velha é " + conta1.ToString());
                }
                else
                {
                    conta = mulherB + homemA;
                    conta1 = mulherA * homemB;

                    MessageBox.Show("soma do homem mais velho e mulher mais nova é " + conta.ToString() + "o produto do homem mais novo e da mulher mais velha é " + conta1.ToString());

                }

            }
            else
            {
                if (mulherA < mulherB)
                {
                    conta = mulherA + homemB;
                    conta1 = mulherB * homemA;

                    MessageBox.Show("soma do homem mais velho e mulher mais nova é " + conta.ToString() + "o produto do homem mais novo e da mulher mais velha é " + conta1.ToString());
                }
                else
                {
                    conta = mulherB + homemB;
                    conta1 = mulherA * homemA;

                    MessageBox.Show("soma do homem mais velho e mulher mais nova é " + conta.ToString() + "o produto do homem mais novo e da mulher mais velha é " + conta1.ToString());

                }

            }
        }

        private void buttonexer21_Click(object sender, EventArgs e)
        {
            double pesomorango, pesomaca,total,total2,quanto;
            pesomorango = (double)numericUpDownpesodoMorango.Value;
            pesomaca = (double)numericUpDownpesodamaca.Value;
            if (pesomaca < 5)
            {
                total = pesomaca * 1.8;
            }
            else
            {
                total = pesomaca * 1.5;

            }
            if (pesomorango < 5)
            {
                total2 = pesomorango * 2.5;
            }
            else
            {
                total2 = pesomorango * 2.2;

            }
            if ((pesomorango + pesomaca) > 8 || (total + total2) > 25)
            {
                quanto = (total2 + total);
                quanto = (quanto) - (quanto * 0.1);

            }
            else
            {
                quanto = (total2 + total);

            }
            MessageBox.Show("o preço total é: R$ " + quanto.ToString("F2"),"total");

        }
    }
}
