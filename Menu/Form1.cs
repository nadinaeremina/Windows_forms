using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Menu
{
    // FontDialog - выбрать шрифт, его начертания
    public partial class Form1 : Form
    {
        Color c;
        FontDialog fd = new FontDialog();
        string docName = "";
        public Form1()
        {
            InitializeComponent();
            c = BackColor; // запоминаем текущий цвет формы
            menuStrip1.Visible = false;
            bt_language.Text = "Ehglish";
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender; // обязательно приведение типа
            if (it.Checked == true) { BackColor = Color.Red; }
            else { BackColor = c; }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender; // обязательно приведение типа
            if (it.Checked == true) { BackColor = Color.Green; }
            else { BackColor = c; }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionFont = fd.Font; }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionColor = colorDialog1.Color; }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName == "")
                    return;
                else
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    docName = openFileDialog1.FileName;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (docName == "") { return; }
                else
                {
                    StreamWriter sw = new StreamWriter(docName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_language_Click(object sender, EventArgs e)
        {
            if(bt_language.Text.CompareTo("English") == 0)
            {
                bt_language.Text = "Русский";
                menuStrip1.Visible = true;
                menuStrip2.Visible = false;
            }
            else
            {
                bt_language.Text = "English";
                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
                MainMenuStrip = menuStrip2;
            }
        }
    }
}
