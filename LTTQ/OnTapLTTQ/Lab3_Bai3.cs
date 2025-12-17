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
    public partial class Lab3_Bai3 : Form
    {
        public Lab3_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Color> colors = new List<Color>();
            foreach (Color color in new ColorConverter().GetStandardValues())
            {
                colors.Add(color);
            }
            int i = random.Next(0, colors.Count());
            try
            {
                this.BackColor = colors[i];
            }
            catch (ArgumentException)
            {

            }
        }
    }
}
