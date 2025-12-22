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
    public partial class Lab5_Bai6 : Form
    {
        public Lab5_Bai6()
        {
            InitializeComponent();
            listBox1.DrawMode = DrawMode.OwnerDrawVariable;
            listBox1.ItemHeight = 25;
            listBox1.DrawItem += ListBox1_DrawItem;
        }
        private void ListBox1_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();

            string text = listBox1.Items[e.Index].ToString() ?? "";

            Font font = new Font(text, 15);
            e.Graphics.DrawString(text, font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();

        }

        private void Lab5_Bai6_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                string x = font.Name;

                listBox1.Items.Add(x);
            }
        }
    }
}
