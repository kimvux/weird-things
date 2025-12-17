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
    public partial class Lab3_Bai2 : Form
    {
        public Lab3_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string str = "Paint event";
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(BackColor);
            float x = random.Next(0, 500);
            float y = random.Next(0, 500);
            graphics.DrawString(str, new Font("Arial", 30), Brushes.Black, new PointF(x, y));
        }
    }
}
