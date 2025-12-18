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
    public partial class Lab3_Bai9 : Form
    {
        class Sinhvien
        {
            public string? MaSV { get; set; }
            public string? Hoten { get; set; }
            public string? Chuyennganh { get; set; }
            public string? Gioitinh { get; set; }
            public int Somon { get; set; }
            public List<string>? Danhsach { get; set; }
        }
        BindingList<Sinhvien> sinhviens = new BindingList<Sinhvien>();
        BindingList<string> nganh = new BindingList<string> {
            "Hệ Thống Thông Tin",
            "Công Nghệ Thông Tin",
            "Khoa Học Máy Tính",
            "Kỹ Thuật Phần Mềm",
            "Kỹ Thuật Máy Tính",
            "Truyền Thông và Mạng Máy Tính",
            "Thương Mại Điện Tử"
        };
        public Lab3_Bai9()
        {
            InitializeComponent();
            dataGridView1.DataSource = sinhviens;
            comboBox1.DataSource = nganh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var x in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(x)) listBox2.Items.Add(x);
            }
            listBox1.SelectedItems.Clear();
            listBox2.SelectedItems.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox2.SelectedItems.Count != 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            listBox1.SelectedItems.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;
            List<string> x = new List<string>();
            foreach (var item in listBox2.Items)
            {
                x.Add(item.ToString() ?? "");
            }
            Sinhvien sinhvien = sinhviens.FirstOrDefault(x => x.MaSV == textBox1.Text);
            if (sinhvien != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thay đổi không", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                sinhvien.Hoten = textBox2.Text;
                sinhvien.Chuyennganh = comboBox1.SelectedItem.ToString();
                sinhvien.Gioitinh = radioButton1.Checked == true ? "Nam" : "Nữ";
                sinhvien.Danhsach = x;
                sinhvien.Somon = x.Count;
            }
            else
            {
                sinhviens.Add(new Sinhvien
                {
                    MaSV = textBox1.Text,
                    Hoten = textBox2.Text,
                    Chuyennganh = comboBox1.SelectedItem.ToString(),
                    Gioitinh = radioButton1.Checked == true ? "Nam" : "Nữ",
                    Danhsach = x,
                    Somon = x.Count
                });
                MessageBox.Show("Lưu thành công");
            }
            listBox1.SelectedItems.Clear();
            listBox2.SelectedItems.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sinhviens;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sinhvien sinhvien = sinhviens.FirstOrDefault(x => x.MaSV == textBox1.Text);
            if (sinhvien != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xoá không", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                sinhviens.Remove(sinhvien);
            }
            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = true;
            listBox1.SelectedItems.Clear();
            listBox2.SelectedItems.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sinhviens;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                listBox2.Items.Clear();
                DataGridViewRow data = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = data.Cells[0].Value?.ToString();
                textBox2.Text = data.Cells[1].Value?.ToString();
                comboBox1.SelectedIndex = comboBox1.FindStringExact(data.Cells[2].Value?.ToString());
                if (data.Cells[3].Value?.ToString() == "Nam")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                Sinhvien sinhvien = sinhviens.FirstOrDefault(x => x.MaSV == textBox1.Text);
                if (sinhvien != null)
                {
                    foreach (var item in sinhvien.Danhsach)
                    {
                        listBox2.Items.Add(item);
                    }
                }
            }
            listBox1.SelectedItems.Clear();
            listBox2.SelectedItems.Clear();
        }
    }
}
