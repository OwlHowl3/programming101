using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int number = int.Parse(Interaction.InputBox("Please type in a number"));

            palindrome(number);
        }

        static void palindrome(int number)
        {
            Console.WriteLine("Original number: " + number);
            int originalNumber = number;

            int reverseNumber = 0;
            while (number > 0)
            {
                int reminder = number % 10;
                reverseNumber = (reverseNumber * 10) + reminder;
                number = number / 10;
            }

            if (originalNumber == reverseNumber) {
                Console.WriteLine("Number is a palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}
