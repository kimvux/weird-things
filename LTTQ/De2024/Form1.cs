using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace De2024
{
    public partial class Form1 : Form
    {
        public class Donhang
        {
            public string? Tenhang { get; set; }
            public string? Donvitinh { get; set; }
            public string? Nhacungcap { get; set; }
            public int Soluongton { get; set; }
        }
        BindingList<Donhang> donhangs = new BindingList<Donhang>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = donhangs;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            dataGridView1.DataSource = null;
            donhangs.Add(new Donhang
            {
                Tenhang = form.ten,
                Donvitinh = form.dv,
                Nhacungcap = form.ncc,
                Soluongton = form.sl
            });
            dataGridView1.DataSource = donhangs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                comboBox1_SelectedIndexChanged(sender, e);
            }
            else
            {
                BindingList<Donhang> newDanhsach = new BindingList<Donhang>();
                foreach (var x in donhangs)
                {
                    if (x.Tenhang.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        if (comboBox1.SelectedIndex == 0) newDanhsach.Add(x);
                        else if (comboBox1.SelectedIndex == 1 && x.Soluongton > 0) newDanhsach.Add(x);
                        else if (comboBox1.SelectedIndex == 2 && x.Soluongton == 0) newDanhsach.Add(x);
                    }
                }
                dataGridView1.DataSource = newDanhsach;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = donhangs;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                BindingList<Donhang> newDanhsach = new BindingList<Donhang>();
                foreach (var x in donhangs)
                {
                    if (x.Soluongton > 0)
                    {
                        newDanhsach.Add(x);
                    }
                }
                dataGridView1.DataSource = newDanhsach;
            }
            else
            {
                BindingList<Donhang> newDanhsach = new BindingList<Donhang>();
                foreach (var x in donhangs)
                {
                    if (x.Soluongton == 0)
                    {
                        newDanhsach.Add(x);
                    }
                }
                dataGridView1.DataSource = newDanhsach;
            }
            if (textBox1.Text != "") textBox1_TextChanged(sender, e);
        }
    }
}
