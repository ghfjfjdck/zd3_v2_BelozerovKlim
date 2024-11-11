using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD3
{
    class Q
    {

        public double Roadwidth;
        public double dlina;
        public double massa;
        public double q;

        public double Qmath(double w, double d, double m)
        {
            double result = w * d * (m / 1000);
                q = result;
            return result;
        }

      
        


    }
}
