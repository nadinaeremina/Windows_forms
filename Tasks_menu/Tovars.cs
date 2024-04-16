using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Tasks_menu
{
    public partial class Tovars : Form
    {
        public Tovars()
        {
            InitializeComponent();
        }

        private List<string> Trim_string(string stroka)
        {
            List<string> mas_str = new List<string>();
            string str = "";
            for (int i = 0; i < stroka.Length - 1; i++)
            {
                if (stroka[i] != ' ')
                    str += stroka[i];
                if ((i == stroka.Length - 2 || stroka[i] == ' ') && str.Length > 0)
                {
                    mas_str.Add(str);
                    str = "";
                }
            }
            return mas_str;
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            Add add = new Add();
            if (add.ShowDialog() == DialogResult.OK)
            {
                string position = $"{add.Name,-100} {add.Producer,-100} {add.Price,-90}";
                listBox1.Items.Add(position);
            }
        }

        private void bt_edit_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string full = Convert.ToString(listBox1.SelectedItem);
                string my_str = "";
                int index = 0;
                bool kruchok = false;
                List<string> mas = new List<string>();
                string str_name = "";
                string str_prod = "";

                for (int i = 0; i < full.Length; i++)
                {
                    if (full[i] != ' ' && full[i] != '/')
                        my_str += full[i];
                    if ((full[i] == ' ' || i == full.Length - 1) && my_str.Length > 0)
                    {
                        if (my_str[my_str.Length - 1] == '/' && kruchok == false)
                        {
                            kruchok = true;
                            index = mas.Count;
                        }
                        mas.Add(my_str);
                        my_str = "";
                    }
                }

                str_name = mas[0];
                if (index > 0)
                {
                    str_name += " ";
                    for (int i = 1; i <= index; i++)
                    {
                        str_name += mas[i];
                        str_name += " ";
                    }
                }

                for (int i = index + 1; i < mas.Count - 1; i++)
                {
                    str_prod += mas[i];
                    str_prod += " ";
                }

                Add add = new Add(str_name, str_prod, mas[mas.Count - 1]);
                if (add.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    string position = $"{add.Name} {add.Producer,100} {add.Price,90}";
                    listBox1.Items.Add(position);
                }
            }
            else
                MessageBox.Show("Сначала выберите позицию!");
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                MessageBox.Show("Сначала выберите позицию!");
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_save_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string filePath = "tovars.txt";
                List<string> my_mas_str = new List<string>();
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        foreach (string item in listBox1.Items)
                        {
                            my_mas_str = Trim_string(item);
                            for (int i = 0; i < my_mas_str.Count; i++)
                            {
                                sw.Write(my_mas_str[i]);
                                sw.Write(" ");
                            }
                            sw.WriteLine(" ");
                        }
                        sw.Dispose();
                    }
                }
                MessageBox.Show("Данные сохранены!");
            }
            else
                MessageBox.Show("Наименований не найдено!");
        }

        private void button_load_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
