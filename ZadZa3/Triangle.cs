using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadZa3
{
    public class Triangle
    {

        public static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double Area(double a, double b, double c)
        {
            double p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }





    }
}
