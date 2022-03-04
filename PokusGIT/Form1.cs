using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int soucet = a + b;
            int rozdil = a - b;
            int soucin = a * b;
            int podil = a / b;
            label1.Text = "Součet obou čísel je: " + soucet;
            label2.Text = "Rozdíl obou čísel je: " + rozdil;
            label3.Text = "Součin obou čísel je: " + soucin;
            label4.Text = "Podíl obou čísel je: " + podil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ITA2\n" + "Dvořák Jakub");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z = int.Parse(textBox3.Text);
            int faktorial = 1;

            for (int i = 1; i <= z; ++i) faktorial *= i;
            label5.Text = "Faktoriál tohoto čísla je: " + faktorial;
        }
    }
}
