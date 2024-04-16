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
    public partial class Form1 : Form
    {
        Color c; // создадим переменную для хранения цвета
        string docName = " ";
        public Form1()
        {
            InitializeComponent();
            Initialisation_language();
            c = BackColor; // запоминаем текущий цвет формы
        }

        // должен стоять "CheckOnClick = true" для того, чтобы реагировать на событие 
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        // 'object sender' - обьект, кот. вызвал событие, 'e' - пар-р на событие, кот. мы должны отраб-ть
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender; // создаем переменную // обязательно приведение типа
            if (it.Checked == true) { BackColor = Color.SkyBlue; }
            else { BackColor = c; }
        }

        // FontDialog - выбрать шрифт, его начертания // можно выбрать в панели инструментов, мы создадим
        FontDialog fd = new FontDialog(); // создаем обьект
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionFont = fd.Font; }
        }

        // ColorDialog - выбрать цвет // можно выбрать в панели инструментов, можно создать
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK) { richTextBox1.SelectionColor = colorDialog1.Color; }
        }

        // 'OpenFileDialog' - // можно выбрать в панели инструментов, можно создать
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if (docName != " ")
                MessageBox.Show("Сначала сохраните предыдущий файл!");
            else
            {
                openFileDialog1.FileName = " ";
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*"; // какие файлы мы можем открыть
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.FileName == " ")
                        return;
                    else
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        richTextBox1.Text = sr.ReadToEnd(); // читаем от начала до конца
                        sr.Close();
                        docName = openFileDialog1.FileName;
                    }
                }
            }
        }

        // 'SaveFileDialog - // можно выбрать в панели инструментов, можно создать
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
                MessageBox.Show("У вас пустой файл!");
            else
            {
                StreamWriter sw;
                if (docName != " ")
                {
                    saveFileDialog1.FileName = docName;
                    sw = new StreamWriter(docName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                    docName = " ";
                }
                else
                {
                    saveFileDialog1.FileName = " ";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialog1.FileName != " ")
                        {
                            sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.WriteLine(richTextBox1.Text);
                            sw.Close();
                        }
                        else
                            return;
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
                MessageBox.Show("У вас пустой файл!");
            else
            {
                StreamWriter sw;
                if (docName != " ")
                {
                    saveFileDialog1.FileName = docName;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialog1.FileName != " " && saveFileDialog1.FileName != docName)
                        {
                            sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.WriteLine(richTextBox1.Text);
                            sw.Close();
                        }
                        else
                            return;
                    }
                    docName = " ";
                }
                else
                {
                    saveFileDialog1.FileName = " ";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialog1.FileName != " ")
                        {
                            sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.WriteLine(richTextBox1.Text);
                            sw.Close();
                        }
                        else
                            return;
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //docName = " ";
            Close();
           
            // хотите сохранить ?
        }

        private void RusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fILEToolStripMenuItem.Text = "Файл";
            openToolStripMenuItem.Text = "Открыть";
            saveToolStripMenuItem.Text = "Сохранить";
            closeToolStripMenuItem.Text = "Закрыть";
            editToolStripMenuItem.Text = "Редактировать";
            copyToolStripMenuItem.Text = "Копировать";
            cutToolStripMenuItem.Text = "Вырезать";
            pasteToolStripMenuItem.Text = "Вставить";
            viewToolStripMenuItem.Text = "Вид";
            fontToolStripMenuItem.Text = "Шрифт";
            alignmentToolStripMenuItem.Text = "Выравнивание";
            chooseLangToolStripMenuItem.Text = "Язык";

            toolStripButton1.ToolTipText = "Открыть";
            toolStripButton2.ToolTipText = "Сохранить";
            toolStripButton4.ToolTipText = "Копировать";
            toolStripButton5.ToolTipText = "Вырезать";
            toolStripButton6.ToolTipText = "Вставить";
            toolStripButton7.ToolTipText = "Стиль";
            toolStripButton8.ToolTipText = "Цвет";
            toolStripButton3.ToolTipText = "Закрыть";
            toolStripButton9.ToolTipText = "По левому";
            toolStripButton10.ToolTipText = "По правому";
            toolStripButton11.ToolTipText = "По центру";
            toolStripButton12.ToolTipText = "Русский";
            toolStripButton13.ToolTipText = "Английский";

            colorToolStripMenuItem1.Text = "цвет";
        }

        private void EngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fILEToolStripMenuItem.Text = "File";
            openToolStripMenuItem.Text = "Open";
            saveToolStripMenuItem.Text = "Save";
            closeToolStripMenuItem.Text = "Close";
            editToolStripMenuItem.Text = "Edit";
            copyToolStripMenuItem.Text = "Copy";
            cutToolStripMenuItem.Text = "Cut";
            pasteToolStripMenuItem.Text = "Paste";
            viewToolStripMenuItem.Text = "View";
            fontToolStripMenuItem.Text = "Font";
            alignmentToolStripMenuItem.Text = "Allignment";
            chooseLangToolStripMenuItem.Text = "Language";

            Initialisation_language();
        }

        private void Initialisation_language()
        {
            toolStripButton1.ToolTipText = "Open";
            toolStripButton2.ToolTipText = "Save";
            toolStripButton4.ToolTipText = "Copy";
            toolStripButton5.ToolTipText = "Cut";
            toolStripButton6.ToolTipText = "Past";
            toolStripButton7.ToolTipText = "Font";
            toolStripButton8.ToolTipText = "Color";
            toolStripButton3.ToolTipText = "Close";
            toolStripButton9.ToolTipText = "on the left";
            toolStripButton10.ToolTipText = "on the right";
            toolStripButton11.ToolTipText = "centered";
            toolStripButton12.ToolTipText = "Russian";
            toolStripButton13.ToolTipText = "English";
          
            colorToolStripMenuItem1.Text = "color";
        }
        private void onTheLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void onTheRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centeredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            if (it.Checked == true) { BackColor = Color.Red; }
            else BackColor = c;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            if (it.Checked == true) { BackColor = Color.Green; }
            else BackColor = c;
        }
    }
}
