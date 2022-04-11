using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text));
            MessageBox.Show(osoba.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pacient pacient = new Pacient(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));
            MessageBox.Show(pacient.ToString());
        }
    }
}
