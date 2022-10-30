using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        Double? first = null;
        Double? second = null;
        string operation;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "1";
                label1.Text = label1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "2";
                label1.Text = label1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "3";
                label1.Text = label1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "4";
                label1.Text = label1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "5";
                label1.Text = label1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "6";
                label1.Text = label1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "7";
                label1.Text = label1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "8";
                label1.Text = label1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "9";
                label1.Text = label1.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "0")
            {
                textboxValue.Text = textboxValue.Text + "0";
                label1.Text = label1.Text + "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textboxValue.Text != "")
            {
                textboxValue.Text = textboxValue.Text + ".";
                label1.Text = label1.Text + ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textboxValue.Text = "";
            label1.Text = "";
            this.first = null;
            this.second = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            first = Double.Parse(textboxValue.Text);

            textboxValue.Text = "";
            this.operation = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            second = Double.Parse(textboxValue.Text);
            Double result;
            switch (this.operation)
            {
                case "+":
                    result = (double)first + (double)second;
                    break;
                default:
                    result = (double)second;
                    break;
            }
            textboxValue.Text = result.ToString(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
