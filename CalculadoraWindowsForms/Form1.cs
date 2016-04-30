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
        int number1 = 0;
        int number2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tela.Text += "+";
            Text = "Soma";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tela.Text += "-";
            Text = "Subtra";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Tela.Text += "*";
            Text = "Multipli";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Tela.Text += "/";
            Text = "Divisão";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Text == null && number1 == 0)
            {
                number1 = 9;
            }
            else if(Text != null && number1 != 0)
            {
                number2 = 9;
                Tela.Text += 9;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 8;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 8;
                Tela.Text += 8;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 7;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 7;
                Tela.Text += 7;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 6;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 6;
                Tela.Text += 6;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 5;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 5;
                Tela.Text += 5;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 4;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 4;
                Tela.Text += 4;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 3;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 3;
                Tela.Text += 3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 2;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 2;
                Tela.Text += 2;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Text == null && number1 == 0)
            {
                number1 = 1;
            }
            else if (Text != null && number1 != 0)
            {
                number2 = 1;
                Tela.Text += 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch(Text)
            {
                case "Soma":
                    Tela.Text = Convert.ToString(number1 + number2);
                    break;
                case "Subtra":
                    Tela.Text = Convert.ToString(number1 + number2);
                    break;
                case "Multipli":
                    Tela.Text = Convert.ToString(number1 + number2);
                    break;
                case "Divisão":
                    Tela.Text = Convert.ToString(number1 + number2);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            Text = null;
        }
    }
}
