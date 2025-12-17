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
    public partial class Lab3_Bai8 : Form
    {
        class Khachhang
        {
            public string? STK { get; set; }
            public string? Ten { get; set; }
            public string? Diachi { get; set; }
            public double Sotien { get; set; }
        }
        BindingList<Khachhang> khachhangs = new BindingList<Khachhang>();
        public Lab3_Bai8()
        {
            InitializeComponent();
            dataGridView1.DataSource = khachhangs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool changed = false;
            double sum = 0;
            foreach (var kh in khachhangs)
            {
                if (kh.STK == textBox1.Text)
                {
                    kh.Ten = textBox2.Text ?? "";
                    kh.Diachi = textBox3.Text ?? "";
                    kh.Sotien = double.Parse(textBox4.Text == "" ? "0" : textBox4.Text);
                    changed = true;
                }
                sum += kh.Sotien;
            }
            if (!changed)
            {
                khachhangs.Add(new Khachhang
                {
                    STK = textBox1.Text ?? "",
                    Ten = textBox2.Text ?? "",
                    Diachi = textBox3.Text ?? "",
                    Sotien = double.Parse(textBox4.Text == "" ? "0" : textBox4.Text)
                });
                sum += double.Parse(textBox4.Text == "" ? "0" : textBox4.Text);
            }
            textBox5.Text = sum.ToString();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = khachhangs;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(textBox4.Text);
            }
            catch (FormatException)
            {
                textBox4.Text = "";
            }
        }
    }
}