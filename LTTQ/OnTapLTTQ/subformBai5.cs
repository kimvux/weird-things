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
    public partial class subformBai5 : Form
    {
        public string mssv = "";
        public string ten = "";
        public string khoa = "";
        public double diemtb = 0;
        public bool isSave = false;
        public subformBai5()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập mssv");
                return;
            }
            try
            {
                diemtb = double.Parse(textBox3.Text);
                if (diemtb < 0 || diemtb > 10) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập đúng định dạng điểm");
                return;
            }
            mssv = textBox1.Text;
            ten = textBox2.Text;
            khoa = comboBox1.Text;
            isSave = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
