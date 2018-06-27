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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lista31bimexer1a3_Load(object sender, EventArgs e)
        {

        }

        private void buttondificil_Click(object sender, EventArgs e)
        {
            int nota100 = 0, nota50 = 0, nota10 = 0, nota5 = 0, nota1 = 0, num1 = 0;
            num1 = (int)(numericUpDownRecebeValor.Value);
            if (num1 >= 100)
            {
                nota100 = num1 / 100;
                num1 = num1 % 100;

            }
            if (num1 >= 50)
            {
                nota50 = num1 / 50;
                num1 = num1 % 50;

            }
            if (num1 >= 10)
            {
                nota10 = num1 / 10;
                num1 = num1 % 10;

            }
            if (num1 >= 5)
            {
                nota5 = num1 / 5;
                num1 = num1 % 5;

            }
            if (num1 >= 1)
            {
                nota1 = num1 / 1;


            }
            MessageBox.Show("o troco fica em " + nota100.ToString() + " notas de 100 " + "mais " + nota50.ToString() + " notas de 50 " + " mais "
             + nota10.ToString() + " notas de 10 " + " mais " + nota5.ToString() + " notas de 5 " +
            " mais " + nota1.ToString() + " notas de 1 ","BOTÃO DIFICIL");


        }

        private void buttonfacil_Click(object sender, EventArgs e)
        {
            int nota100 = 0, nota50 = 0, nota10 = 0, nota5 = 0, nota1 = 0, num1 = 0;
            num1 = (int)(numericUpDownRecebeValor.Value);

            while (num1 >= 100)
            {
                num1 =num1- 100;
                nota100++;
            }
            while (num1 >= 50)
            {
                num1=num1 -50;
                nota50++;
            }
            while (num1 >= 10)
            {
                num1 =num1 -10;
                nota10++;
            }
            while (num1 >= 5)
            {
                num1 =num1 -5;
                nota5++;
            }
            while (num1 >= 1)
            {
                num1 = num1-1;
                nota1++;
            }

            MessageBox.Show("o troco fica em " + nota100.ToString() + " notas de 100 " + "mais " + nota50.ToString() + " notas de 50 " + " mais "
            + nota10.ToString() + " notas de 10 " + " mais " + nota5.ToString() + " notas de 5 " +
           " mais " + nota1.ToString() + " notas de 1 ","BOTÃO FACIL");
        }

        private void button1Calculaexer3_Click(object sender, EventArgs e)
        {
            double consumo, tempo, valorQuilo,potencia;
            tempo = (double)numericUpDownTempo.Value;
            valorQuilo = (double)numericUpDownValorQuilo.Value;
            potencia = (double)numericUpDownPotencia.Value;
            consumo = (potencia * tempo) / 1000;
            consumo = consumo * valorQuilo;
            MessageBox.Show("O valor gasto pelo consumo é :" + consumo.ToString());
        }
    }
}
