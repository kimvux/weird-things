using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapLTTQ
{
    public partial class Lab5_Bai4 : Form
    {
        public Lab5_Bai4()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families)
            {
                this.comboBox1.Items.Add(font.Name);
            }
            comboBox1.SelectedItem = "Arial";
            comboBox2.SelectedItem = "14";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Font = new Font(comboBox1.Text, float.Parse(comboBox2.Text));
            }
            catch (FormatException)
            {
                comboBox2.Text = "14";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = color.Color;
                textBox1.ForeColor = color.Color;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Bold);
            else
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
            else
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
            else
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Underline);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (!button.Checked) return;
            if (button.Name == "radioButton1")
            {
                textBox1.TextAlign = HorizontalAlignment.Left;
            }
            else if (button.Name == "radioButton2")
            {
                textBox1.TextAlign = HorizontalAlignment.Center;
            }
            else
            {
                textBox1.TextAlign = HorizontalAlignment.Right;
            }
        }
    }
}
