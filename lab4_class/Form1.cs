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

namespace lab4_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] vector = new int[] { 42, 8, 4, 16, 23, 15, 16 };
            int valoareCautata = 16;

            int index = -1;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == valoareCautata)
                {
                    index = i;
                    break;
                }
            }
            
            if (index == -1)
            {
                Console.WriteLine("Value not found");
            } else
            {
                Console.WriteLine("Value found at index " + index);
            }
            //------------------------------------------------------- 

            int[] vector2 = new int[] { 42, 8, 4, 16, 23, 15, 16 };
            int valoareCautata2 = 16;

            ArrayList indecsi = new ArrayList();

            for (int i = 0; i < vector2.Length; i++)
            {
                if (vector2[i] == valoareCautata2)
                {
                    indecsi.Add(i);
                }
            }

            if (indecsi.Count == 0)
            {
                Console.WriteLine("Indexes not found");
            }
            else
            {
                foreach (int i in indecsi)
                {
                    Console.WriteLine("Found at index " + i);
                }
            }

            ////-------------------------------------------------------

            int[] vector3 = { 4, 8, 15, 16, 23, 42 };
            int valoareCautata3 = 13;
            int index3 = -1;

            for (int i = 0; i < vector3.Length; i++)
            {
                if (vector3[i] == valoareCautata3)
                {
                    index3 = i;
                    break;
                }
                if (vector3[i] > valoareCautata3)
                {
                    break;
                }
            }

            if (index3 == -1)
            {
                Console.WriteLine("No index found");
            }
            else
            {
                Console.WriteLine("Value found at index" + index3);
            }

        }
    }
}
