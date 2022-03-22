using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Calculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResulte.Text = txtResulte.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResulte.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResulte.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResulte.Text != "")
            {
                valor1 = decimal.Parse(txtResulte.Text, CultureInfo.InvariantCulture);
                txtResulte.Text = "";
                operacao = "SUBTRAÇÃO";
                lblOperacao.Text = "-";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtResulte.Text != "")
            {
                valor1 = decimal.Parse(txtResulte.Text, CultureInfo.InvariantCulture);
                txtResulte.Text = "";
                operacao = "MULTIPLICAÇÃO";
                lblOperacao.Text = "x";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResulte.Text != "")
            {
                valor1 = decimal.Parse(txtResulte.Text, CultureInfo.InvariantCulture);
                txtResulte.Text = "";
                operacao = "DIVISÃO";
                lblOperacao.Text = "/";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtResulte.Text != "")
            {
                valor2 = decimal.Parse(txtResulte.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResulte.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "DIVISÃO")
                {
                    txtResulte.Text = Convert.ToString(valor1 / valor2);
                }
                else if (operacao == "SUBTRAÇÃO")
                {
                    txtResulte.Text = Convert.ToString(valor1 - valor2);
                }
                else
                {
                    txtResulte.Text = Convert.ToString(valor1 * valor2);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResulte.Text = "";
            lblOperacao.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtResulte.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtResulte.Text != "")
            {
                valor1 = decimal.Parse(txtResulte.Text, CultureInfo.InvariantCulture);
                txtResulte.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }
    }
}
