using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int n;

            n = int.Parse(
                Interaction.InputBox("Type in the number of values")
            );

            int[] values = new int[n];

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(
                    Interaction.InputBox("Please give me number " + (i + 1))
                );
                values[i] = value;
            }

            int min; int max;
            min = int.Parse(
                Interaction.InputBox("Min value?")
            );
            max = int.Parse(
                Interaction.InputBox("Max value?")
            );

            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min || values[i] > max)
                {
                    count++;
                }
            }

            MessageBox.Show("Total values not in range: " + count.ToString());
        }
    }
}
