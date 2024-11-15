using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD3
{
    class Q // Класс Q
    {
        string name; // Доп поле 1
        string country; // Доп поле 2
         double roadwidth; // Ширина дороги
        double dlina; // Длина
         double massa; // масса
         double q; //Q

        public Q()// Конструктор
        {


        }
        public double Qmath(double w, double d, double m) // Функция Q
        {
            double result = w * d * (m / 1000); // Формула
            q = result;
            return result;
        }

        public double Roadwidth{ //Свойство

                    get { return roadwidth; } set {  roadwidth = value; }

                }

        public double Dlina { //Свойство
        
                        get { return dlina; } set {  dlina = value; }
        
        
        
        }

        public double Massa // Свойство
        {

            get { return massa; } set {  massa = value; }



        }

        public double QQ //Свойство
        {

            get { return q; }
            set { q = value; }



        }
        public string Name //Свойство
        {

            get { return name; }
            set { name = value; }



        }
        public string Country //Свойство
        {

            get { return country; }
            set { country = value; }



        }



    }
}
