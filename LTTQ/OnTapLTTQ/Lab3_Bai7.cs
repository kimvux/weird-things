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
    public partial class Lab3_Bai7 : Form
    {
        double sum = 0;
        public Lab3_Bai7()
        {
            InitializeComponent();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button button)
                {
                    if (button.BackColor == Color.Cyan)
                    {
                        button.BackColor = Color.Yellow;
                        if (double.Parse(button.Text) >= 1 && double.Parse(button.Text) <= 5) sum += 5000;
                        if (double.Parse(button.Text) >= 6 && double.Parse(button.Text) <= 10) sum += 6500;
                        if (double.Parse(button.Text) >= 11 && double.Parse(button.Text) <= 15) sum += 8000;
                    }
                }
            }
            textBox1.ReadOnly = false;
            textBox1.Text = sum.ToString();
            textBox1.ReadOnly = true;
            sum = 0;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button button)
                {
                    if (button.BackColor == Color.Cyan)
                    {
                        button.BackColor = Color.White;
                    }
                }
            }
            textBox1.ReadOnly = false;
            textBox1.Text = sum.ToString();
            textBox1.ReadOnly = true;
            sum = 0;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Cyan)
            {
                button.BackColor = Color.White;
            }
            else if (button.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vị trí đã được bán");
            }
            else
            {
                button.BackColor = Color.Cyan;
            }
        }
    }
}
