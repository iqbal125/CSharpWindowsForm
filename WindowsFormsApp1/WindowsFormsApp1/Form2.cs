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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length1feet, length1inch, length2feet, length2inch;

            length1feet = int.Parse(textBox1.Text);
            length1inch = int.Parse(textBox2.Text);
            length2feet = int.Parse(textBox3.Text);
            length2inch = int.Parse(textBox4.Text);

            int length1feet2inch = length1feet * 12;
            Console.WriteLine(length1feet2inch);
            int length2feet2inch = length2feet * 12;
            Console.WriteLine(length2feet2inch);

            int totalinchlen1 = length1feet2inch + length1inch;
            Console.WriteLine(totalinchlen1);
            int totalinchlen2 = length2feet2inch + length2inch;
            Console.WriteLine(totalinchlen2);

            int totalinches = totalinchlen1 + totalinchlen2;
            Console.WriteLine(totalinches);
            int totalfeet = totalinches / 12;
            Console.WriteLine(totalfeet);

            int remaininch = totalinches % 12;
            Console.WriteLine(remaininch);

            textBox5.Text = totalfeet.ToString();
            textBox6.Text = remaininch.ToString();



        }
    }
}
