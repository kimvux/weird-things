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
    public partial class Lab4_Bai5 : Form
    {
        class Sinhvien
        {
            public string? mssv { get; set; }
            public string? ten { get; set; }
            public string? khoa { get; set; }
            public double diemtb { get; set; }
        }
        BindingList<Sinhvien> sinhviens = new BindingList<Sinhvien>();
        public Lab4_Bai5()
        {
            InitializeComponent();
            dataGridView1.DataSource = sinhviens;
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subformBai5 bai5 = new subformBai5();
            bai5.ShowDialog();
            if (bai5.isSave == false) return;
            foreach (var x in sinhviens)
            {
                if (x.mssv == bai5.mssv)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại !");
                    return;
                }
            }
            dataGridView1.DataSource = null;
            sinhviens.Add(new Sinhvien
            {
                mssv = bai5.mssv,
                ten = bai5.ten,
                khoa = bai5.khoa,
                diemtb = bai5.diemtb
            });
            dataGridView1.DataSource = sinhviens;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                dataGridView1.DataSource = sinhviens;
            }
            else
            {
                BindingList<Sinhvien> newsv = new BindingList<Sinhvien>();
                foreach (var sv in sinhviens)
                {
                    if (sv.ten.ToLower().Contains(toolStripTextBox1.Text.ToLower()))
                        newsv.Add(sv);
                }
                dataGridView1.DataSource = newsv;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
