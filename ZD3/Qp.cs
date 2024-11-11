using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZD3
{
    class Qp:Q
    {

        public int p;
        public double qp;
        List<Qp> list = new List<Qp>();

        public double Qpmath(Qp ex)
        {
            double result=ex.Qmath(ex.Roadwidth,ex.dlina,ex.massa);
                ex.q = result;
            if (ex.p >= 5 && ex.p <= 8)
            {
               ex.qp = result * 1.1;
                return ex.qp;


            }else
                if (ex.p == 3 || ex.p == 4 || ex.p == 9 || ex.p == 10)
            {

                ex.qp = result * 1.6;
                return ex.qp;


            }
            else
            {
                ex.qp = result * 1.9;
                return ex.qp;
            }
        }

        
        public void Addobject(NumericUpDown num1, NumericUpDown num2, NumericUpDown num3, NumericUpDown num4)
        {
            Qp road1 = new Qp();
            road1.Roadwidth = Convert.ToDouble(num1.Value);
            road1.dlina = Convert.ToDouble(num2.Value);
            road1.massa = Convert.ToDouble(num3.Value);
            road1.p = Convert.ToInt32(num4.Value);
                road1.Qpmath(road1);
            list.Add(road1);

        }

        public void Listrestart(ListBox list1)
        {
            list1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                list1.Items.Add($"Ширина {list[i].Roadwidth} Длина {list[i].dlina} Масса {list[i].massa} Коэф прочности {list[i].p} Q = {list[i].q} Qp = {list[i].qp}");
            }


        }

    }
}
