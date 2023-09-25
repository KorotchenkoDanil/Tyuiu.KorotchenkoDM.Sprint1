using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task4.V11.Lib
{
    public class DataService : ISprint1Task4V11
    {
        public double Calculate(double x, double y)
        {
            double res0 = Math.Atan(x) / Math.Exp(y);
            double res = Math.Round(res0, 3);
            return res;
        }
    }
}
