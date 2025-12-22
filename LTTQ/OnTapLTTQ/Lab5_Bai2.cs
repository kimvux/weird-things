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
    public partial class Lab5_Bai2 : Form
    {
        public Lab5_Bai2()
        {
            InitializeComponent();
        }

        private void Lab5_Bai2_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(BackColor);
            graphics.DrawRectangle(Pens.Black, new Rectangle(e.X - 25, e.Y - 25, 50, 50));
        }
    }
}
