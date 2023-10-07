using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KosovAS.Sprint2.Task4.V4.Lib
{
    public class DataService : ISprint2Task4V4
    {
        public double Calculate(double x, double y)
        {
            double z;
            z = x + 2 < y ? z = Math.Sin(x) + 2 * y : z = Math.Cos(y) + 2 * x * y;
            return Math.Round(z, 3);
        }
    }
}
