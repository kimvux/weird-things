using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapLTTQ
{
    public partial class Lab3_Bai5 : Form
    {
        public Lab3_Bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                textBox3.ReadOnly = false;
                textBox3.Text = (num1 + num2).ToString();
                textBox3.ReadOnly = true;
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                textBox3.ReadOnly = false;
                textBox3.Text = (num1 - num2).ToString();
                textBox3.ReadOnly = true;
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                textBox3.ReadOnly = false;
                textBox3.Text = (num1 * num2).ToString();
                textBox3.ReadOnly = true;
            }
            catch (Exception)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                textBox3.ReadOnly = false;
                textBox3.Text = (num1 / num2).ToString();
                textBox3.ReadOnly = true;
            }
            catch (Exception)
            {

            }
        }
    }
}
