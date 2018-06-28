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
    public partial class loops13a19 : Form
    {
        public loops13a19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            double cima = 1, baixo = 1, termos, progressao = 3;
            double conta = 0;
            termos = (int)numericUpDownParatodos.Value;
            for (int i = 1; i <= termos; i++)
            {
                cima = cima + 1;
                if (i == 1)
                {
                    baixo = 1;
                }
                else
                {
                    baixo = baixo + progressao;
                }
                conta = (cima / baixo) + conta;
                if (i != 1)
                {
                    progressao = progressao + 2;
                }
            }
            richTextBoxMostrar.AppendText(conta.ToString("n3"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int quanto;
            string aste = "";
            quanto = (int)numericUpDownParatodos.Value;
            for (int i = 1; i <= quanto; i++)
            {
                aste = aste + "*";
                richTextBoxMostrar.AppendText(aste.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int quanto;
            string guarda = "";
            quanto = (int)numericUpDownParatodos.Value;
            for (int i = 1; i <= quanto; i++)
            {

                guarda = guarda + Convert.ToString(i);
                i = Convert.ToInt16(i);
                richTextBoxMostrar.AppendText(guarda.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int quanto, bandeira = 0;
            string guarda = "", espaco = "";

            quanto = (int)numericUpDownParatodos.Value;
            for (int i = 1; i <= quanto; i++)
            {

                for (int z = quanto; z >= i; z--)
                {
                    espaco = espaco + "  ";

                }

                for (int x = 1; x <= i; x++)
                {


                    bandeira = i;
                    guarda = guarda + " " + bandeira;

                }
                guarda =guarda + espaco ;
                richTextBoxMostrar.AppendText(guarda.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);
                guarda = "";
                espaco = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int quanto, bandeira = 0;
            string guarda = "", espaco = "";

            quanto = (int)numericUpDownParatodos.Value;
            for (int i = 1; i <= quanto; i++)
            {

                for (int z = quanto; z >= i; z--)
                {
                    espaco = espaco + "  ";

                }

                for (int x = 1; x <= i; x++)
                {


                    bandeira = bandeira + 1;
                    guarda = guarda + " " + bandeira;

                }
                guarda =  guarda+espaco;
                richTextBoxMostrar.AppendText(guarda.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);
                guarda = "";
                espaco = "";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int quanto, bandeira = 0;
            string guarda = "", espaco = "";

            quanto = (int)numericUpDownParatodos.Value;
            for (int i = 1; i <= quanto; i++)
            {

                for (int z = quanto; z >= i; z--)
                {
                    espaco = espaco + " ";

                }

                for (int x = 1; x <= i; x++)
                {

                    bandeira = bandeira + 1;
                    guarda = guarda + " " + bandeira;



                }
                guarda = espaco + guarda;
                richTextBoxMostrar.AppendText(guarda.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);
                guarda = "";
                espaco = "";
            }
        }

        private void buttonExer19_Click(object sender, EventArgs e)
        {
            richTextBoxMostrar.Clear();
            int quanto;
            string guarda = "", espaco = "";

            quanto = (int)numericUpDownParatodos.Value;
            for (int i = 1; i <= quanto; i++)
            {

                for (int z = quanto; z >= i; z--)
                {
                    espaco = espaco + " ";

                }

                for (int x = 1; x <= i; x++)
                {



                    guarda = guarda + " " + "*";

                }
                guarda = espaco + guarda;
                richTextBoxMostrar.AppendText(guarda.ToString());
                richTextBoxMostrar.AppendText(Environment.NewLine);
                guarda = "";
                espaco = "";
            }
        }
    }
}
