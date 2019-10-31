using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_8
{    
    class Program
    {
        static double Func(double x)
        {
            return x-4;
        }

        static double Bisection(double min,double max, double e=0.000001)
        {
            if (Math.Abs(Math.Abs(min-max)) < e) return max;

            var x = (max+min) / 2;

            if (Func(x)< 0) min = x;

            else max = x;

            return Bisection(min, max);
        }

        static void Main(string[] args)
        {
            var i = Bisection(1,10);
            Console.WriteLine("{0}", i);
            Console.ReadKey();
        }
    }
}
