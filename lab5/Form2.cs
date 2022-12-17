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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace lab5
{
    public partial class Form2 : Form
    {
        // Preluaţi de la utilizator un număr n.

        // Preluaţi apoi n valori numerice într-un vector.

        // Preluaţi de la utilizator 2 valori: a şi b.

        // Generaţi un alt vector care să conţină valorile care
        // nu sunt între a şi b.Afişaţi apoi numărul acestor valori.

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
