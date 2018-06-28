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
    public partial class exer7a9 : Form
    {
        public exer7a9()
        {
            InitializeComponent();
        }

        private void buttoncalculasalario_Click(object sender, EventArgs e)
        {
            double salarioFixo, salariofinal,valorPorCarro, totaldeVendas, quantosCarros;
            salarioFixo = (double)numericUpDownsalariofixo.Value;
            valorPorCarro = (double)numericUpDownvaloporcarro.Value;
            totaldeVendas = (double)numericUpDowntotaldevendas.Value;
            quantosCarros = (double)numericUpDowncarrosvendidos.Value;
            salariofinal = (salarioFixo + (totaldeVendas * 0.05)) + 
                (valorPorCarro * quantosCarros);
            MessageBox.Show("o salário final é de: " + salariofinal.ToString("f2") + "R$","botão calcula" +
                "");

        }

        private void buttontransforma_Click(object sender, EventArgs e)
        {
            double far, celsi;
            far = (double)numericUpDowntrnasformagraus.Value;
            celsi = 1.8 * far + 32;
            MessageBox.Show("a temperatura em celsius é de: " + celsi.ToString() + "graus","botão transforma" +
                "");

        }

        private void buttoncalculamedia_Click(object sender, EventArgs e)
        {
            double nota20, nota30, nota50, media;
            nota20 = (double)numericUpDownnota20.Value;
            nota30 = (double)numericUpDownnota30.Value;
            nota50 = (double)numericUpDownnota50.Value;
            media = (nota20 * 0.2) + (nota30 * 0.3) + (nota50 * 0.5);
            MessageBox.Show("a media do aluno é: " + media.ToString(), "botão media");

        }
    }
}
