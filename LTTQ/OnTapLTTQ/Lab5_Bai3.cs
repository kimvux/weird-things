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
    public partial class Lab5_Bai3 : Form
    {
        float orgsize = 40;
        float crsize = 40;
        float x, y;
        public Lab5_Bai3()
        {
            InitializeComponent();
        }

        private void Lab5_Bai3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics graphics = this.CreateGraphics();
                graphics.Clear(BackColor);
                crsize = orgsize;
                x = e.X;
                y = e.Y;
                graphics.DrawEllipse(Pens.Black, new RectangleF(x - crsize / 2, y - crsize / 2, crsize, crsize));
            }
        }

        private void Lab5_Bai3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus)
            {
                Graphics graphics = this.CreateGraphics();
                graphics.Clear(BackColor);
                crsize += 10;
                graphics.DrawEllipse(Pens.Black, new RectangleF(x - crsize / 2, y - crsize / 2, crsize, crsize));
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                Graphics graphics = this.CreateGraphics();
                graphics.Clear(BackColor);
                crsize -= 10;
                if (crsize <= 0) crsize = 0;
                graphics.DrawEllipse(Pens.Black, new RectangleF(x - crsize / 2, y - crsize / 2, crsize, crsize));
            }
        }
    }
}
