using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindur
{
    public class CilindurData
    {
        public static double Volume(double r, double h)
        {
            return Math.PI * (r * r) * h;
        }

        public static double Area(double r, double h)
        {
            return 2 * Math.PI * r * h;
        }


    }
}
