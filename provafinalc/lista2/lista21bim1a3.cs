using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provafinalc.lista2
{
    public partial class lista21bim1a3 : Form
    {
        public lista21bim1a3()
        {
            InitializeComponent();
        }

        private void buttoninforma_Click(object sender, EventArgs e)
        {
            double media;
            media = (double)numericUpDownmedia.Value;
            if (media < 70)
            {

                MessageBox.Show("REPROVADO", "botão ap/rep");

            }
            else {

                MessageBox.Show("aprovado", "botão ap/rep");
            }
        }

        private void buttonnegativopositivo_Click(object sender, EventArgs e)
        {
            double numero;
            numero = (double)numericUpDownpositivonegativo.Value;
            if (numero < 0)
            {

                MessageBox.Show("o numero é negativo"+numero.ToString(), "botão informa");

            }
            else
            {

                MessageBox.Show("o numero é positivo" + numero.ToString(), "botão informa");
            }
        }

        private void buttonexcesso_Click(object sender, EventArgs e)
        {
            double peso,excesso=0,multa=0;
            peso = (double)numericUpDownpeso.Value;
            if (peso > 40)
            {
                excesso = (peso - 40);
                multa = excesso * 4;
                MessageBox.Show("o peso excedido é: " + excesso.ToString() + "e a multa a ser paga é de: R$ " + multa.ToString("f2"));
            }
            else
            { MessageBox.Show("o peso excedido é: " + excesso.ToString() + " e a multa a ser paga é de: R$ " + multa.ToString("f2")); }
        }
    }
}
