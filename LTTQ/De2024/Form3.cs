using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De2024
{
    public partial class Form3 : Form
    {
        public string ten = "";
        public string dv = "";
        public string ncc = "";
        public int sl = 0;
        public Form3()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") return;
            ten = textBox1.Text;
            dv = textBox2.Text;
            ncc = comboBox1.Text;
            try
            {
                sl = int.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập đúng định dạng");
                return;
            }
            this.Close();
        }
    }
}
