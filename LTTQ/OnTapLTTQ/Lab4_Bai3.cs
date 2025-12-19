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
    public partial class Lab4_Bai3 : Form
    {
        public Lab4_Bai3()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov;*.wmv;*.flv|All Files|*.*"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = open.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
