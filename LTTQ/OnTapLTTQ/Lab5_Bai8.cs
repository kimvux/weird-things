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
    public partial class Lab5_Bai8 : Form
    {
        Bitmap bitmap;
        public Lab5_Bai8()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen s = new Pen(Color.Red, 2);
            Pen m = new Pen(Color.Black, 5);
            Pen h = new Pen(Color.DarkGray, 10);

            graphics.Clear(Color.Transparent);
            graphics.TranslateTransform(216, 212);

            var statehour = graphics.Save();
            graphics.RotateTransform(DateTime.Now.Hour * 30 + DateTime.Now.Minute / 2);
            graphics.DrawLine(h, 0, 0, 0, -90);
            graphics.Restore(statehour);

            var stateminute = graphics.Save();
            graphics.RotateTransform(DateTime.Now.Minute * 6);
            graphics.DrawLine(m, 0, 0, 0, -180);
            graphics.Restore(stateminute);

            var statesecond = graphics.Save();
            graphics.RotateTransform(DateTime.Now.Second * 6);
            graphics.DrawLine(s, 0, 0, 0, -190);
            graphics.Restore(statesecond);

            graphics.FillEllipse(Brushes.Black, -10, -10, 20, 20);

            pictureBox1.Refresh();
        }
    }
}
