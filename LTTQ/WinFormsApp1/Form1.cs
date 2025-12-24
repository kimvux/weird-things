using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int sodem;
        public class Booking
        {
            public string? MaDatPhong { get; set; }
            public string? TenKhach { get; set; }
            public string? SoDienThoai { get; set; }
            public string? LoaiPhong { get; set; }
            public string? NgayNhan { get; set; }
            public string? NgayTra { get; set; }
            public double TienCoc { get; set; }
            public double TongTien { get; set; }
        }
        BindingList<Booking> bookings = new BindingList<Booking>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = bookings;
            comboBox1.SelectedIndex = 0;
            TuDongDanhSTT();
            textBox5.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") return;
            if (textBox2.Text.Length > 11 || textBox2.Text.Length < 9) return;
            try
            {
                double coc = double.Parse(textBox3.Text);
                if (coc < 100000 || coc >= 500000) return;
            }
            catch (FormatException)
            {
                return;
            }

            dataGridView1.DataSource = null;
            foreach (Booking x in bookings)
            {
                if (x.MaDatPhong == textBox1.Text)
                {
                    x.SoDienThoai = textBox2.Text;
                    x.NgayNhan = dateTimePicker1.Text;
                    x.TienCoc = double.Parse(textBox3.Text);
                    x.TenKhach = textBox4.Text;
                    x.LoaiPhong = comboBox1.Text;
                    x.NgayTra = dateTimePicker2.Text;
                    x.TongTien = double.Parse(textBox5.Text);
                    dataGridView1.DataSource = bookings;
                    TuDongDanhSTT();
                    return;
                }
            }
            bookings.Add(new Booking
            {
                MaDatPhong = textBox1.Text,
                SoDienThoai = textBox2.Text,
                NgayNhan = dateTimePicker1.Text,
                TienCoc = double.Parse(textBox3.Text),
                TenKhach = textBox4.Text,
                LoaiPhong = comboBox1.Text,
                NgayTra = dateTimePicker2.Text,
                TongTien = double.Parse(textBox5.Text)
            });
            dataGridView1.DataSource = bookings;
            TuDongDanhSTT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Booking x in bookings)
            {
                if (x.MaDatPhong == textBox1.Text)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.DataSource = null;
                        bookings.Remove(x);
                    }
                    dataGridView1.DataSource = bookings;
                    TuDongDanhSTT();
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan time = dateTimePicker2.Value.Date - dateTimePicker1.Value.Date;
            sodem = time.Days;
            if (sodem < 0)
            {
                MessageBox.Show("Ngày trả phải lớn hon ngày nhận");
                return;
            }
            double giaphong = 0;
            if (comboBox1.SelectedIndex == 0) giaphong = 300000;
            if (comboBox1.SelectedIndex == 1) giaphong = 500000;
            if (comboBox1.SelectedIndex == 2) giaphong = 800000;
            textBox5.Text = (sodem * giaphong).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells[1].Value?.ToString();
                    textBox2.Text = row.Cells[3].Value?.ToString();
                    textBox3.Text = row.Cells[7].Value?.ToString();
                    textBox4.Text = row.Cells[2].Value?.ToString();
                    comboBox1.Text = row.Cells[4].Value?.ToString();
                    textBox5.Text = row.Cells[8].Value?.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[5].Value);
                    dateTimePicker2.Value = Convert.ToDateTime(row.Cells[6].Value);
                }
                catch (FormatException)
                {

                }
                catch (ArgumentNullException)
                {

                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
        }
        private void TuDongDanhSTT()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double giaphong = 0;
            if (comboBox1.SelectedIndex == 0) giaphong = 300000;
            if (comboBox1.SelectedIndex == 1) giaphong = 500000;
            if (comboBox1.SelectedIndex == 2) giaphong = 800000;
            textBox5.Text = (sodem * giaphong).ToString();
        }
    }
}
