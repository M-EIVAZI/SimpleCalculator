using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double operand1;
        double operand2;
        //double result;
        char opt;
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text+= button12.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
            opt = '+';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //textBox1.Text =Convert.ToString( sum + Convert.ToInt32(textBox1.Text));
            operand2 = Double.Parse(textBox1.Text);
            switch(opt)
            {
                case '+':
                    textBox1.Text =Convert.ToString( operand1 + operand2);
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(operand1 - operand2);
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(operand1 * operand2);
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(operand1 / operand2);
                    break;
                case '^':
                    textBox1.Text = Convert.ToString(Math.Pow(operand1, operand2));
                    break;
                case '%':
                    textBox1.Text = Convert.ToString((int)operand1 % (int)operand2);
                    break;
            }
            operand1 = 0;
            operand2 = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
            opt = '-';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
            opt = '*';

        }

        private void button17_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(textBox1.Text);
            textBox1.Clear();
            opt = '/';
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(operand1));
            operand1 = 0;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(textBox1.Text);
            opt = '^';
            textBox1.Clear();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            operand1 = Double.Parse(textBox1.Text);
            opt = '%';
            textBox1.Clear();

        }
    }
}
