using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD3
{
    class Qp:Q// Класс Qp наследник от класса Q
    {

        double p; // Поле коэфициент
         double qp;
        List<Qp> list = new List<Qp>();// Лист

        public List<Qp> List// Свойство 
        {
            get { return list; }
           
        }
        public void Qmath(Qp ex)// Метод для расчета Qp
        {
            double result=ex.Qmath(ex.Roadwidth,ex.Dlina,ex.Massa); // В переменную result возвращает расчет из метода Qmath
                ex.QQ = result; // в поле q в базовом классе присваивает значение result
            if (ex.p >= 5 && ex.p <= 8)                                  ///////
            {                                                                //
               ex.qp = result * 1.1;                                        //
                                                                           //
                                                                          //              
                                                                         //
            }else                                                       //
                if (ex.p == 3 || ex.p == 4 || ex.p == 9 || ex.p == 10) /////////// Если P=3, 4, 9, 10 то Qp=Q*1,6 иначе Qp = 1,9 * Q
                {                                                     //
                                                                     //
                ex.qp = result * 1.6;                               //
                                                                   //
                                                                  //            
                                                                 //
                 }                                              //
            else                                          ///////
            {
                ex.qp = result * 1.9;
               
            }
        }
        
        
        public void Addobject(NumericUpDown num1, NumericUpDown num2, NumericUpDown num3, NumericUpDown num4,TextBox txt,TextBox txt2)
        {
            //Метод добавления 
            Qp road1 = new Qp();// Создает экземпляр Qp
            road1.Roadwidth = Convert.ToDouble(num1.Value);// в поле ширина присваивается num1
            road1.Dlina = Convert.ToDouble(num2.Value);// в поле dlina присваивается num2
            road1.Massa = Convert.ToDouble(num3.Value);// в поле massa присваивается num3
            road1.p = Convert.ToDouble(num4.Value);// в поле p присваивается num4
            road1.Country = txt.Text;// в поле country присваивается txt
            road1.Name = txt2.Text;// в поле name присваивается txt2
            road1.Qmath(road1); // Вызываеться метод Qmath
            list.Add(road1); // Экземпляр добавляется в лист

        }

        public void Listrestart(ListBox list1) // обновляет listBox
        {
            list1.Items.Clear(); //Очищает лист
            for (int i = 0; i < list.Count; i++) 
            {
                list1.Items.Add($"Страна {list[i].Country} Название дороги {list[i].Name} Ширина {list[i].Roadwidth} Длина {list[i].Dlina} Масса {list[i].Massa} Коэф прочности {list[i].p} Q = {list[i].QQ} Qp = {list[i].qp}");
                //добавляет в listbox элемент
            }


        }

        public void Listrestart(int d, ListBox list1)//перегрузка метода Listrestart которая удаляет из listBox элемент
        {
            list1.Items.RemoveAt(d);// удаляет элемент из listBox по индексу
                list.RemoveAt(d); // удаляет из List<Qp> list экзмепляр по индексу
        }

    }
}
