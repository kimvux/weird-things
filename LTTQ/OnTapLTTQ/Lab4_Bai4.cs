using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnTapLTTQ
{
    public partial class Lab4_Bai4 : Form
    {
        string FilePath = "";
        bool isSave = true;
        bool isBold = false;
        bool isUnderline = false;
        bool isItalic = false;
        public Lab4_Bai4()
        {
            InitializeComponent();
            foreach (var font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            toolStripComboBox1.SelectedIndex = 0;
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilePath = richTextBox1.Text = "";
            isBold = isItalic = isUnderline = false;
            isSave = true;
            toolStripComboBox1.SelectedItem = "Tahoma";
            toolStripComboBox2.SelectedItem = "14";
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSave == false)
            {
                DialogResult result = MessageBox.Show("Do you want to save?", "", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel) return;
                if (result == DialogResult.Yes) lưuNộiDungVănBảnToolStripMenuItem_Click(sender, e);
            }
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Text Files|*.txt|Rich Text Format|*.rtf"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(open.FileName).ToLower() == ".rtf")
                    richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.UnicodePlainText);
                FilePath = open.FileName;
                isSave = true;
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePath == "")
            {
                var save = new SaveFileDialog
                {
                    Filter = "Text Files|*.txt|Rich Text Format|*.rtf"
                };
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(save.FileName).ToLower() == ".rtf")
                        richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.UnicodePlainText);
                    FilePath = save.FileName;
                }
            }
            else
            {
                MessageBox.Show("Lưu thành công");
                if (Path.GetExtension(FilePath).ToLower() == ".rtf")
                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.SaveFile(FilePath, RichTextBoxStreamType.UnicodePlainText);
            }
            isSave = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSave == false)
            {
                DialogResult result = MessageBox.Show("Do you want to save?", "", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel) return;
                if (result == DialogResult.Yes) lưuNộiDungVănBảnToolStripMenuItem_Click(sender, e);
            }
            this.Close();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox1.Text, float.Parse(toolStripComboBox2.Text));
            }
            catch (FormatException)
            {
                toolStripComboBox2.Text = "14";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (isBold == false)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                isBold = true;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                isBold = false;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (isItalic == false)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
                isItalic = true;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                isItalic = false;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (isUnderline == false)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
                isUnderline = true;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                isUnderline = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }
    }
}
