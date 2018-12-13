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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numa = Convert.ToDouble(textBox1.Text);
            var numb = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (numa + numb).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var numa = Convert.ToDouble(textBox1.Text);
            var numb = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (numa - numb).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var numa = Convert.ToDouble(textBox1.Text);
            var numb = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (numa * numb).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var numa = Convert.ToDouble(textBox1.Text);
            var numb = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (numa / numb).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("plz enter your number" + textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("wrong calculation" + textBox1.Text);
            }
        }
    }
}