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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
                return;
            }
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
                    MessageBox.Show("Cập nhật thành công");
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
                MessageBox.Show("Thêm mới thành công");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value?.ToString();
                textBox2.Text = row.Cells[1].Value?.ToString();
                textBox3.Text = row.Cells[2].Value?.ToString();
                textBox4.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = khachhangs.FirstOrDefault(x => x.STK == textBox1.Text);
            if (khachhang != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc không", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                textBox5.Text = (double.Parse(textBox5.Text) - khachhang.Sotien).ToString();
                khachhangs.Remove(khachhang);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = khachhangs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}