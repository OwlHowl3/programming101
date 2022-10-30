using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            int a;
            a = int.Parse(
                Interaction.InputBox("Number a?")
            );

            ArrayList valuesLessThanA = new ArrayList();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < a)
                {
                    valuesLessThanA.Add(values[i]);
                }
            }

            MessageBox.Show(
                "Total values less than " + a.ToString() + ": " + valuesLessThanA.Count.ToString()
            );

            string itemsString = "";
            for (var i = 0; i < valuesLessThanA.Count; i++)
            {
                itemsString += valuesLessThanA[i].ToString();
                if (i != valuesLessThanA.Count - 1)
                {
                    itemsString += ",";
                }
            }
            MessageBox.Show("Values: " + itemsString);
        }
    }
}
