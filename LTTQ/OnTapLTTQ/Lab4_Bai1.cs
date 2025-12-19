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
    public partial class Lab4_Bai1 : Form
    {
        public Lab4_Bai1()
        {
            InitializeComponent();
        }
        private void Lab4_Bai1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse: " + e.Button.ToString();
            label2.Text = "[" + e.X.ToString() + "," + e.Y.ToString() + "]";
        }
        private void Lab4_Bai1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "Key: " + e.KeyData.ToString();
            label2.Text = "Data number: " + e.KeyValue.ToString();
        }
    }
}
