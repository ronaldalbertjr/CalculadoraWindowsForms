using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        string Text;
        string number1, number2;
        bool par1 = false;
        int rn1, rn2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                Tela.Text += "+";
                Text = "Soma";
                par1 = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                Tela.Text += "-";
                Text = "Subtra";
                par1 = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                Tela.Text += "*";
                Text = "Multipli";
                par1 = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                Tela.Text += "/";
                Text = "Divisão";
                par1 = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!par1)
            {
                number1 += "9";
                Tela.Text += 9;
            }
            else 
            {
                number2 += "9";
                Tela.Text += 9;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "8";
                Tela.Text += 8;
            }
            else 
            {
                number2 = "8";
                Tela.Text += 8;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "7";
                Tela.Text += 7;
            }
            else
            {
                number2 = "7";
                Tela.Text += 7;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "6";
                Tela.Text += 6;
            }
            else
            {
                number2 = "6";
                Tela.Text += 6;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "5";
                Tela.Text += 5;
            }
            else
            {
                number2 += "5";
                Tela.Text += 5;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "4";
                Tela.Text += 4;
            }
            else
            {
                number2 += "4";
                Tela.Text += 4;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "3";
                Tela.Text += 3;
            }
            else
            {
                number2 += "3";
                Tela.Text += 3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "2";
                Tela.Text += 8;
            }
            else
            {
                number2 += "2";
                Tela.Text += 2;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!par1)
            {
                number1 += "1";
                Tela.Text += 1;
            }
            else
            {
                number2 += "1";
                Tela.Text += 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            rn1 = Convert.ToInt32(number1);
            rn2 = Convert.ToInt32(number2);
            switch(Text)
            {
                case "Soma":
                    Tela.Text = Convert.ToString(rn1 + rn2);
                    break;
                case "Subtra":
                    Tela.Text = Convert.ToString(rn1 - rn2);
                    break;
                case "Multipli":
                    Tela.Text = Convert.ToString(rn1 * rn2);
                    break;
                case "Divisão":
                    Tela.Text = Convert.ToString(rn1 / rn2);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rn1 = 0;
            rn2 = 0;
            number1 = null;
            number2 = null;
            Tela.Text = null;
            par1 = false;
        }
    }
}
