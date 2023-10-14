using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        int n = 0;
        int size = 0;
        bool is_k = false;
        bool is_ch = false;

        private void calculate()
        {
            switch (n)
            {
                case 1:
                    {
                        a = a - b;
                        textBox1.Text = a.ToString();
                        size = textBox1.Text.Length;
                        break;
                    }
                case 2:
                    {
                        a = a + b;
                        textBox1.Text = a.ToString();
                        size = textBox1.Text.Length;
                        break;
                    }
                case 3:
                    {
                        a = a * b;
                        textBox1.Text = String.Format("{0:0.##########}", a);
                        size = textBox1.Text.Length;
                        break;
                    }
                case 4:
                    {
                        if (b == 0)
                        {
                            MessageBox.Show("Деление на ноль невозможно");
                        }
                        else
                        {
                            a = a / b;
                            textBox1.Text = String.Format("{0:0.##########}", a);
                            size = textBox1.Text.Length;
                        }
                        break;
                    }
                default:
                    {
                        textBox1.Text = "error";
                        break;
                    }
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            is_ch = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !is_k)
            {
                a = double.Parse(textBox1.Text);
                n = 3;
                textBox1.Text += "*";
                size = textBox1.Text.Length;
                is_k = true;
                is_ch = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            is_ch = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            is_ch = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            is_ch = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            is_ch = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            is_ch = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            is_ch = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            is_ch = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            is_ch = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !is_k)
            {
                a = double.Parse(textBox1.Text);
                n = 2;
                textBox1.Text += "+";
                size = textBox1.Text.Length;
                is_k = true;
                is_ch = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !is_k)
            {
                a = double.Parse(textBox1.Text);
                n = 1;
                textBox1.Text += "-";
                is_k = true;
                is_ch = false;
            }
            else textBox1.Text = "-" + textBox1.Text;
            size = textBox1.Text.Length;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !is_k)
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text += "/";
                size = textBox1.Text.Length;
                n = 4;
                is_k = true;
                is_ch = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (size != 0 && is_ch)
            {
                b = double.Parse(textBox1.Text.Substring(size));
                calculate();
                is_k = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Clear();
                is_k = false;
                size--;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            is_ch = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
    }
}
