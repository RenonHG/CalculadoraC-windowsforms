using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            float total = float.Parse(numero1) + float.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            float total = float.Parse(numero1) - float.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            float total = float.Parse(numero1) * float.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            float total = float.Parse(numero1) / float.Parse(numero2);

            lbResultado.Text = total.ToString();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {
            float numero3 = float.Parse(txbNumero3.Text);

            //OU
            //string numero3 = txbNumero3.Text;
            //float numero = float.Parse(numero3);

            if (numero3 > 0)
            {
                lbResultado.Text = "O numero digitado é MAIOR que 0!";
            }
            else if (numero3 < 0)
            {
                lbResultado.Text = "O numero digitado é MENOR que 0!";
            }
            else
            {
                lbResultado.Text = "O numero digitado é IGUAL a 0!";
            }

        }

        private void txbNumero3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbImparPar_Click(object sender, EventArgs e)
        {
            float numero3 = float.Parse(txbNumero3.Text);

            if (numero3 % 2 == 0)
            {
                lbResultado.Text = "O número digitado é PAR";
            }
            
            else
            {
                lbResultado.Text = "O número digitado é ÍMPAR";
            }

        }
    }
}
