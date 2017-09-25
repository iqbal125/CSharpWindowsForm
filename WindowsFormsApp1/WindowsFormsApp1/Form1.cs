using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loan, rate, term, MonthPay, MonthRate, MonthLoan, MonthTerm;
            loan = double.Parse(textBox1.Text);
            Console.WriteLine(loan);
            rate = double.Parse(textBox2.Text);
            Console.WriteLine(rate);
            term = double.Parse(textBox3.Text);
            Console.WriteLine(term);
            MonthRate = rate/12;
            Console.WriteLine(MonthRate);
            MonthLoan = loan * MonthRate;
            Console.WriteLine(MonthLoan);
            MonthTerm = -12 * term;
            Console.WriteLine(MonthTerm);
            MonthPay = MonthLoan / 1 - Math.Pow(1 + MonthRate, MonthTerm);
            Console.WriteLine(MonthPay);
            textBox4.Text = MonthPay.ToString();

        }
    }
}
