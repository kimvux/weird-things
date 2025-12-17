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
    public partial class Lab3_Bai1 : Form
    {
        public Lab3_Bai1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            subform sub = new subform();
            sub.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
