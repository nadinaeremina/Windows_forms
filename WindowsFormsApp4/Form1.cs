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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string[] russia = { "Екатеринбург", "Москва", "Санкт-Петербург" };
        string[] america = { "Вашингтон", "Нью-Йорк", "Лос-Анджелес" };
        string[] spain = { "Мадрид", "Барселона", "Валенсия" };
        public Form1()
        {
            InitializeComponent();
            Birthday.MaxDate = new DateTime(DateTime.Now.Year - 18, 1, 1);
            Birthday.MinDate = new DateTime(DateTime.Now.Year - 70, 1, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LastName.Text.Length > 0 && FirstName.Text.Length > 0 && city.Items.Count > 0 && phone.MaskCompleted == true && (Man.Checked == true || Woman.Checked == true) && Birthday.Value != new DateTime(DateTime.Now.Year - 18, 1, 1))
            {
                string str_person = $"ФИО: {LastName.Text} {FirstName.Text} {SurName.Text} \n" +
                          $"Место проживания: {country.SelectedItem} \n" +
                          $" {city.SelectedItem} \n" +
                          $"Телефон: {phone.Text} \n" +
                          $"Дата рождения: {Birthday.Value.ToShortDateString()}\n";

                if (Man.Checked == true) str_person += $"Пол: мужской";
                else if (Woman.Checked == true) str_person += $"Пол: женский";
                MessageBox.Show(str_person, "Анкетные данные");

                XmlSerializer xs = new XmlSerializer(typeof(string)); // передавая обьект - указываем его тип

                // сериализация
                using (Stream fs = File.Create("anketa.xml"))
                {
                    xs.Serialize(fs,str_person); 
                    Console.WriteLine(str_person);
                }
            }
            else
            {
                country.BackColor = Color.LightSteelBlue;
                city.BackColor = Color.LightSteelBlue;
                MessageBox.Show("Не все обязательные поля заполнены!");
            }
        }

        private void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (city.Items.Count > 0)
                city.Items.Clear();
            if (Convert.ToString(country.SelectedItem) == "Россия")
                city.Items.AddRange(russia);
            else if (Convert.ToString(country.SelectedItem) == "США")
                city.Items.AddRange(america);
            else if (Convert.ToString(country.SelectedItem) == "Испания")
                city.Items.AddRange(spain);
        }

        private void LastName_MouseDown(object sender, MouseEventArgs e)
        {
            LastName.BackColor = Color.White;
        }

        private void FirstName_MouseDown(object sender, MouseEventArgs e)
        {
            FirstName.BackColor = Color.White;
        }

        private void LastName_MouseLeave(object sender, EventArgs e)
        {
            if (LastName.Text.Length == 0)
                LastName.BackColor = Color.LightSteelBlue;
        }

        private void FirstName_MouseLeave(object sender, EventArgs e)
        {
            if (FirstName.Text.Length == 0)
                FirstName.BackColor = Color.LightSteelBlue;
        }
    }
}
