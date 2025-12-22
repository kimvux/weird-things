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
    public partial class Lab5_Bai1 : Form
    {
        float x = 200;
        float y = 200;
        public Lab5_Bai1()
        {
            InitializeComponent();
        }

        private void Lab5_Bai1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                y -= 10;
                Graphics graphics = this.CreateGraphics();
                graphics.Clear(BackColor);
                graphics.DrawString("hehe", new Font("Arial", 20), Brushes.Black, new PointF(x, y));
            }
            if (e.KeyCode == Keys.Down)
            {
                y += 10;
                Graphics graphics = this.CreateGraphics();
                graphics.Clear(BackColor);
                graphics.DrawString("hehe", new Font("Arial", 20), Brushes.Black, new PointF(x, y));
            }
            if (e.KeyCode == Keys.Left)
            {
                x -= 10;
                Graphics graphics = this.CreateGraphics();
                graphics.Clear(BackColor);
                graphics.DrawString("hehe", new Font("Arial", 20), Brushes.Black, new PointF(x, y));
            }
            if (e.KeyCode == Keys.Right)
            {
                x += 10;
                Graphics graphics = this.CreateGraphics();
                graphics.Clear(BackColor);
                graphics.DrawString("hehe", new Font("Arial", 20), Brushes.Black, new PointF(x, y));
            }
        }
    }
}
