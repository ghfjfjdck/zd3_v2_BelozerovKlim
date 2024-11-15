using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();// Требуемый метод для поддержки конструктора
        }
        Qp road = new Qp(); // Экземпляр класса Qp
        private void button1_Click(object sender, EventArgs e)// Кнопка добавления
        {
            bool proverka = true; //переменная типа bool
            if (textBox2.Text != "" && textBox2.Text != " ") // условие на проверку пустоты в текстбоксе
            {
                foreach (var con in textBox2.Text) 
                {
                    if (char.IsWhiteSpace(con) || char.IsDigit(con))//проверка на пробелы и цифры
                    {
                        proverka = false; // Переменной proverka присваивается значение false  
                        break;// остановка цикла foreach
                    }


                }
            }
            else
                MessageBox.Show("Пустое поле Страны");// Сообщение если поле Страны пустое

            for (int i = 0; i < road.List.Count; i++)
            {
                if (road.List[i].Name.ToUpper() == textBox1.Text.ToUpper())//проверка на повтор названия дороги
                {
                    proverka = false;// Переменной proverka присваивается значение false  
                    break; // остановка цикла for
                }



            }
            if (proverka&&textBox1.Text!=""&&textBox1.Text!=" ")// условие на проверку пустоты в текстбоксах
            {
                road.Addobject(num1, num2, num3, num4, textBox2, textBox1);//Добавление 
                MessageBox.Show("Добавлено");// Выводит сообщение "Добавлено"
                road.Listrestart(listBox1); // Обновляет listBox
            }
            else
            {
                MessageBox.Show("Неверный формат или такое имя дороги уже есть");
                // Выводит сообщение "Неверный формат или такое имя дороги уже есть" 

            }
        }

        private void button2_Click(object sender, EventArgs e) //Удаление по индексу
        {
            int d = listBox1.SelectedIndex;// Переменная d присваивает индекс выбраной строки в listBox
            if (d!=-1)
            {

                road.Listrestart(d,listBox1);//Метод удаляет элемент из listBox по индексу
                


            }else
            {
                MessageBox.Show("Выберите строчку");
                //Выводит сообщение "Выберите строчку"
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Метод вызываемый при загрузке Формы
        }

        private void button3_Click(object sender, EventArgs e) // Удаление по названию дороги
        {
            bool pr = false;// Переменная pr присваивает значение false (проверка)
            int d = -1; // Переменная d присваивает значение -1 (индекс)
            int check = 0; // Переменная check присваивает 0 (проверка)
            if (textBox3.Text != "" && textBox3.Text != " ") // Проверка на пустое поле
            {

                var search = from t in road.List    //
                             select t;             ////Запрос Linq

                foreach (var sr in search) // Цикл foreach для проверки на существование названия дороги
                {
                    d++; // Увеличивается индекс на 1
                    if (sr.Name.ToUpper() == textBox3.Text.ToUpper()) // Проверка на то что в листе есть название дороги которое нужно удалить
                    {
                        check = 1; // Переменная check присваивает значение 1
                        break; // Остановка цикла
                    }
                    


                }
                if (check==1)
                {
                    road.Listrestart(d, listBox1);// Удаляет из листа по индексу d
                    pr = true; // Переменная pr присваивает значение true

                }

                if (pr)
                {
                    MessageBox.Show("Удалено");
                    // Выводит сообщение "Удалено"

                }else
                {
                    MessageBox.Show("Названия дороги не найдено");
                    //Выводит сообщение "Название дороги не найдено"
                }

            }else
            {
                MessageBox.Show("Пустое поле");
                //Выводит сообщение "Пустое поле" 
            }
        }
    }
}
