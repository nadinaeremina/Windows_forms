using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        // модальные формы - перехватывает на себя все сообщения текущего приложения (для второй формы мы вызвали 'ShowDialog')
        // перейти обратно на первую форму мы не можем, пока не закроем вторую // зависимые друг от друга окна

        // немодальные формы (не тормозят общую работу) (для второй формы мы вызываем метод 'Show')
        // можем работать на обеих формах и на первой снова нажать кнопку и вызвать еще одну форму
        // независимые друг от друга окна

        // закрываем формы явно с помощью метода 'Close'


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Child f2 = new Child();

        //    // работа с модальным окном
        //    //f2.ShowDialog(); 
        //    //MessageBox.Show("END program");

        //    // работа с немодальным окном
        //    f2.Show();
        //    MessageBox.Show("END program");
        //}

        // передача данных от родителя к дочерней
        // все три действия происходят только при создании формы

        // 1 // передача данных от родителя к дочерней // через кон-р дочерней формы
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Child f_child = new Child(tb_parent.Text);
        //    f_child.ShowDialog(); // показываем форму (она модальная)
        //}

        // 2 // через доп.ф-цию и св-во дочерней формы
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Child f_child = new Child();
        //    f_child.My_text = tb_parent.Text;
        //    f_child.ShowDialog();
        //}

        // 3 // через перегрузку ф-ции 'ShowDialog'
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Child f_child = new Child();
        //    f_child.ShowDialog(tb_parent.Text);
        //}
    }
}
