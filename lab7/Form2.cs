using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        // se defineste o lista cu lungimi de apeluri
        
        // pentru fiecare apel se calculeaza costul aplicand taxarea progresiva
        
        // se calculeaza costul tuturor apelurilor

        // se afiseaza valoarea totala 

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] callLengths = new int[] { 400, 900, 850 };
            double totalamount = 0;

            foreach (int callLength in callLengths)
            {
                double amount;

                if (callLength <= 500)
                {
                    amount = callLength * 0.01;
                }
                else if (callLength <= 800)
                {
                    amount = (callLength - 500) * 0.008 + 5; // 500 * 0.01
                }
                else
                {
                    amount = (callLength - 800) * 0.005 + 7.4; // 500 * 0.01 + 300 * 0.008;
                }
                totalamount += amount;
                //Console.WriteLine(amount);
            }

            Console.WriteLine("Total to pay: " + totalamount);
        }
    }
}
