using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_show
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        List<Bitmap> images = new List<Bitmap>(); // 'Bitmap' - это класс, с пом. кот. мы работаем с изображениями
        // для того, чтобы отображать обьекты
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // интервал таймера
            timer.Tick += next_Click; // событие по таймеру 
        }

        int np = 0; // индекс
        private void next_Click(object sender, EventArgs e)
        {
            // переход картинок
            if (images.Count == 0) return; // если нет картинок
            if (np == images.Count)
                np = 0;
            pictureBox1.Image = images[np];
            label1.Text = $"{np+1}/11";
            np++;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            // сначала нужно остановить слайд-шоу и таймер
            timer.Stop();
            // для того, чтобы найти нашу папочку
            FolderBrowserDialog folder = new FolderBrowserDialog(); // исп-ся для выбора папки
            if (folder.ShowDialog() == DialogResult.OK)
            {
                if (images.Count != 0) // если загружены картинки - нужно очистить кол-цию
                {
                    foreach (Bitmap bmp in images)
                        bmp.Dispose(); // отщелкнуть все потоки, очистить операт.память
                    images.Clear(); // очистить кол-цию
                }
            }
            else
                return;

            // обьект, кот. позволяет нам выбрать папочку, кот. будет помещать в себя опред. изоб-ие в нашу кол-цию 'images'
            DirectoryInfo di = new DirectoryInfo(folder.SelectedPath); // 'SelectedPath' - путь к выбранной папке

            IEnumerable<FileInfo> files = di.EnumerateFiles(); // файлы могут быть разного формата - поэтому - IEnumerable
            // 'EnumerateFiles()' - возвращ-ет кол-цию файлов из папки, кот. мы будем выбирать
            foreach (FileInfo file in files)
            {
                string str = Path.GetExtension(file.FullName); // 'Path' (путь) - статич. класс
                // 'GetExtension' - возв-ет расширение у нашего об-та - 'FullName' - полное имя
                if (str == ".bmp" || str == ".jpeg" || str == ".png" || str == ".jpg")
                {
                    Bitmap pt = new Bitmap(file.FullName); // укладываем в обьект 'BitMap' - нашу картинку
                    // подгоняем наши картинки под один размер
                    //Size pt_size = pictureBox1.Size;
                    images.Add(new Bitmap(pt, pictureBox1.Size)); // укладываем картинку в коллекцию
                }
            }

            pictureBox1.Image = images[np];
            label1.Text = $"1/11";
            np++;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (images.Count != 0)
                timer.Start();
            else
                MessageBox.Show("Не выбрана папка с изображениями!");
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            np = 0;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) return; // если нет картинок
            if (np == images.Count)
                np = 0;
            pictureBox1.Image = images[np];
            label1.Text = $"{np + 1}/11";
            np++;
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) return; // если нет картинок
            if (np == 0)
                np = images.Count;
            np--;
            pictureBox1.Image = images[np];
            label1.Text = $"{np + 1}/11";
        }

        private void button_slowly_Click(object sender, EventArgs e)
        {
            if (timer.Interval < 1500)
                timer.Interval += 250;
            else
                MessageBox.Show("К сожалению, это самая медленная скорость");
        }

        private void button_fast_Click(object sender, EventArgs e)
        {
            if (timer.Interval > 500)
                timer.Interval -= 250;
            else
                MessageBox.Show("К сожалению, это самая быстрая скорость");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Close();
        }
    }
}
