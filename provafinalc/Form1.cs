using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using provafinalc.lista3;


namespace provafinalc
{
    public partial class Formprincipalfinal : Form
    {
        public Formprincipalfinal()
        {
            InitializeComponent();
        }

        private void Formprincipalfinal_Load(object sender, EventArgs e)
        {

        }

        private void primeiraListaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercicio1A3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lista1a3 = new lista1a3();

            //lerMostrar.Show();//mostrar
            lista1a3.ShowDialog();
        }

        private void exercicio4A6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lista4a6 = new exercicio4a6();
            lista4a6.ShowDialog();
        }

        private void exercicio7A9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exercicio7a9 = new exer7a9();
            exercicio7a9.ShowDialog();
        }

        private void exercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exer10 = new exercicio10();
            exer10.ShowDialog();
        }

        private void exercicio1A3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form lista1a32bim = new lista21bim1a3();
            lista1a32bim.ShowDialog();
        }

        private void exerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form lista14a6bim = new lista21bim4a6();
            lista14a6bim.ShowDialog();
        }

        private void exercicios7A10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exer7a10 = new lista1bim7a10();
            exer7a10.ShowDialog();
        }

        private void exercicios11A13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exer11a13 = new lista2exer11a13();
            exer11a13.ShowDialog();
        }

        private void exercicios14A16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exer14a16 = new lista21bimexer14a16();
            exer14a16.ShowDialog();
        }

        private void exercicios17A19ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exer17a19 = new lista2bim117a19();
            exer17a19.ShowDialog();
        }

        private void exercicios20E21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exer20e21 = new lista21bimexer2021();
            exer20e21.ShowDialog();
        }

        private void desafioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form desafio = new lista21bimdesafio();
            desafio.ShowDialog();
        }

        private void lista31bimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercicios1A3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exercicio1a3 = new lista31bimexer1a3();
            exercicio1a3.ShowDialog();
        }

        private void exercicios4A6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exercicio4a6 = new lista31bimexer4a6();
            exercicio4a6.ShowDialog();
            
        }

        private void exericios5A6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exer7a9 = new lista31bimexer7a9();
            exer7a9.ShowDialog();
        }
    }
}
