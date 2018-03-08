using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double input1 = 0.0;
        private double input2 = 0.0;
        private double total = 0.0;
        private string operation = string.Empty;
        private Functions test;

        private void Form1_Load(object sender, EventArgs e)
        {
            test = new Functions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            Double.TryParse(label1.Text, out input1 );
            label1.Text = string.Empty;            
            operation = "+";
            label2.Text += input1.ToString()+operation;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Double.TryParse(label1.Text, out input1);
            label1.Text = string.Empty;
            operation = "-";
            label2.Text += input1.ToString() + operation;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Double.TryParse(label1.Text, out input1);
            label1.Text = string.Empty;
            operation = "x";
            label2.Text += input1.ToString() + operation;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double.TryParse(label1.Text, out input1);
            label1.Text = string.Empty;
            operation = "/";
            label2.Text += input1.ToString() + operation;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Double.TryParse(label1.Text, out input1);
            label1.Text = string.Empty;
            operation = "√";
            label2.Text += operation + input1.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Double.TryParse(label1.Text, out input1);
            label1.Text = string.Empty;
            operation = "exp";
            label2.Text += input1.ToString() + "²";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Double.TryParse(label1.Text, out input2);
            label1.Text = string.Empty;

            if(operation.Equals("+"))
            {
                label1.Text = test.Add(input1, input2).ToString();
                label2.Text += input2.ToString();

            }
            else if (operation.Equals("-"))
            {
                label1.Text = test.Sub(input1, input2);
                label2.Text += input2.ToString();
            }
            else if (operation.Equals("x"))
            {
                label1.Text = test.Mult(input1, input2);
                label2.Text += input2.ToString();
            }
            else if (operation.Equals("/"))
            {
                label1.Text = test.div(input1, input2);
                label2.Text += input2.ToString();
            }
            else if (operation.Equals("√"))
            {
                label1.Text = test.SquareRoot(input1);
            }
            else if (operation.Equals("exp"))
            {
                label1.Text = test.exp(input1);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            input1 = 0;
            input2 = 0;
            label1.Text = string.Empty;
            label2.Text = string.Empty;
        }
    }
}
