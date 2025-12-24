using System.ComponentModel;
using System.Windows.Forms;

namespace _24520922_VuHoangKim
{
    public partial class Form1 : Form
    {
        class Sinhvien
        {
            public string? mssv { get; set; }
            public string? ten { get; set; }
            public string? mahp { get; set; }
            public string? tenhp { get; set; }
            public int sotinchi { get; set; }
            public int hocki { get; set; }
            public string? namhoc { get; set; }
            public double dongiatc { get; set; }
            public double thanhtien { get; set; }
        }
        BindingList<Sinhvien> sinhviens = new BindingList<Sinhvien>();

        public Form1()
        {
            InitializeComponent();
            hocki.SelectedIndex = 0;
            dataGridView1.DataSource = sinhviens;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mssv.Text == "" || mahocphan.Text == "" || ten.Text == "" || tenhocphan.Text == "" || sotinchi.Text == "" || namhoc.Text == "" || dongiatc.Text == "") return;
            try
            {
                if (int.Parse(sotinchi.Text) <= 0 || int.Parse(sotinchi.Text) >= 11 || double.Parse(dongiatc.Text) <= 0 || double.Parse(dongiatc.Text) >= 1000000) return;
            }
            catch (FormatException)
            {
                return;
            }
            //mssv
            bool coChuHoa = false;
            bool coChuThuong = false;
            bool coSo = false;
            bool coKyTuDacBiet = false;
            bool coKhoangTrang = false;
            foreach (char c in mssv.Text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    coChuHoa = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    coChuThuong = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    coSo = true;
                }
                else
                {
                    coKyTuDacBiet = true;
                }
                if (coChuHoa && coChuThuong && coSo && coKyTuDacBiet)
                    break;
            }
            if (!coChuHoa || !coChuThuong || !coSo || !coKyTuDacBiet) return;
            //hoten
            coChuHoa = false;
            coChuThuong = false;
            coSo = false;
            coKyTuDacBiet = false;
            foreach (char c in ten.Text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    coChuHoa = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    coChuThuong = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    coSo = true;
                }
                else if (c == ' ')
                {
                    coKhoangTrang = true;
                }
                else
                {
                    coKyTuDacBiet = true;
                }
            }
            if (coSo || coKyTuDacBiet) return;
            //tenhocphan
            coChuHoa = false;
            coChuThuong = false;
            coSo = false;
            coKyTuDacBiet = false;
            foreach (char c in tenhocphan.Text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    coChuHoa = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    coChuThuong = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    coSo = true;
                }
                else if (c == ' ')
                {
                    coKhoangTrang = true;
                }
                else
                {
                    coKyTuDacBiet = true;
                }
            }
            if (coSo || coKyTuDacBiet) return;
            //mahocphan
            coChuHoa = false;
            coChuThuong = false;
            coSo = false;
            coKyTuDacBiet = false;
            foreach (char c in mahocphan.Text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    coChuHoa = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    coChuThuong = true;
                }
                else if (c >= '0' && c <= '9')
                {
                    coSo = true;
                }
                else if (c == ' ')
                {
                    coKhoangTrang = true;
                }
                else
                {
                    coKyTuDacBiet = true;
                }
            }
            if (coKyTuDacBiet) return;

            foreach (var x in sinhviens)
            {
                if (x.mssv == mssv.Text && x.mahp == mahocphan.Text && x.hocki == int.Parse(hocki.Text) && x.namhoc == namhoc.Text)
                {
                    dataGridView1.DataSource = null;
                    x.ten = ten.Text;
                    x.mahp = mahocphan.Text;
                    x.tenhp = tenhocphan.Text;
                    x.sotinchi = int.Parse(sotinchi.Text);
                    x.hocki = int.Parse(hocki.Text);
                    x.namhoc = namhoc.Text;
                    x.dongiatc = double.Parse(dongiatc.Text);
                    x.thanhtien = double.Parse(thanhtien.Text);
                    dataGridView1.DataSource = sinhviens;
                    TuDongDanhSTT();
                    return;
                }
            }
            dataGridView1.DataSource = null;
            sinhviens.Add(new Sinhvien
            {
                mssv = mssv.Text,
                ten = ten.Text,
                mahp = mahocphan.Text,
                tenhp = tenhocphan.Text,
                sotinchi = int.Parse(sotinchi.Text),
                hocki = int.Parse(hocki.Text),
                namhoc = namhoc.Text,
                dongiatc = double.Parse(dongiatc.Text),
                thanhtien = double.Parse(thanhtien.Text)
            });
            dataGridView1.DataSource = sinhviens;
            TuDongDanhSTT();
        }

        private void sotinchi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thanhtien.Text = (int.Parse(sotinchi.Text) * int.Parse(dongiatc.Text)).ToString();
            }
            catch (FormatException)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mssv.Text = "";
            ten.Text = "";
            mahocphan.Text = "";
            tenhocphan.Text = "";
            sotinchi.Text = "";
            hocki.Text = "1";
            namhoc.Text = "";
            dongiatc.Text = "";
            thanhtien.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                string value = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                foreach (var x in sinhviens)
                {
                    if (x.mssv == value)
                    {
                        DialogResult result = MessageBox.Show("Are u sure", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            dataGridView1.DataSource = null;
                            sinhviens.Remove(x);
                            dataGridView1.DataSource = sinhviens;
                            TuDongDanhSTT();
                            return;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                mssv.Text = row.Cells[1].Value?.ToString();
                ten.Text = row.Cells[2].Value?.ToString();
                mahocphan.Text = row.Cells[3].Value?.ToString();
                tenhocphan.Text = row.Cells[4].Value?.ToString();
                sotinchi.Text = row.Cells[5].Value?.ToString();
                hocki.Text = row.Cells[6].Value?.ToString();
                namhoc.Text = row.Cells[7].Value?.ToString();
                dongiatc.Text = row.Cells[8].Value?.ToString();
                thanhtien.Text = row.Cells[9].Value?.ToString();
            }
        }
        private void TuDongDanhSTT()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dataGridView1.DataSource = sinhviens;
                TuDongDanhSTT();
            }
            else
            {
                BindingList<Sinhvien> newsv = new BindingList<Sinhvien>();
                foreach (var sv in sinhviens)
                {
                    if (sv.mssv == textBox1.Text)
                        newsv.Add(sv);
                }
                dataGridView1.DataSource = newsv;
                TuDongDanhSTT();
            }
        }
    }
}
