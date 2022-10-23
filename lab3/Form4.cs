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

namespace lab3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int[] haystack = new int[] { 42, 8, 4, 16, 23, 15, 16 };
            int needle = 16;

            int index = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Element not found.");
            } else
            {
                Console.WriteLine("Element found at index " + index);
            }
            //--------------------------------------------------------------
            ArrayList indexes = new ArrayList();
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle)
                {
                    indexes.Add(i);
                }
            }

            var sb = new StringBuilder();

            for (int i = 0; i < indexes.Count; i++)
            {
                sb.Append(indexes[i]);
                if (i != indexes.Count - 1)
                {
                    sb.Append(",");
                }
            }

            string indexesString = sb.ToString();

            if (indexes.Count == 0)
            {
                Console.WriteLine("Element not found.");
            } else
            {
                Console.WriteLine("Element found at indexes " + indexesString);
            }

            //--------------------------------------------------------------
            int[] haystack2 = { 4, 8, 15, 16, 23, 42 };
            int needle2 = 13;

            int index2 = -1;
            for (int i = 0; i < haystack2.Length; i++)
            {
                if (haystack2[i] == needle2)
                {
                    index2 = i;
                    break;
                }
                if (haystack2[i] > needle2)
                {
                    break;
                }
            }

            if (index2 == -1)
            {
                Console.WriteLine("Element not found");
            } else
            {
                Console.WriteLine("Element found at index: " + index2);
            }
            //--------------------------------------------------------------

            int[] haystack3 = { 4, 8, 15, 16, 23, 42, 51, 61, 88 };
            int needle3 = 61;

            int left = 0;
            int right = haystack3.Length - 1;
            int index3 = -1;

            while (left < right)
            {
                int middle = left + (right - left) / 2;
                //			int middle = (right + left) /2;

                if (haystack3[middle] == needle3)
                {
                    index3 = middle;
                }

                if (haystack3[middle] < needle3)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            if (index3 == -1)
            {
                Console.WriteLine("Element not found");
            } else
            {
                Console.WriteLine("Element found at index " + index3);
            }


        }
    }
}
