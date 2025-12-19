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
    public partial class Lab4_Bai4 : Form
    {
        public Lab4_Bai4()
        {
            InitializeComponent();
            foreach (var font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            toolStripComboBox1.SelectedIndex = 0;
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
