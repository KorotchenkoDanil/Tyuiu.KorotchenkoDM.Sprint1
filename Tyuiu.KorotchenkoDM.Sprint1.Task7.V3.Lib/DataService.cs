using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KorotchenkoDM.Sprint1.Task7.V3.Lib
{
    public class DataService : ISprint1Task7V3
    {
        public double Calculate(double x, double y)
        {
            double res0 = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
            double res = Math.Round(res0, 3);
            return res;
        }
    }
}
