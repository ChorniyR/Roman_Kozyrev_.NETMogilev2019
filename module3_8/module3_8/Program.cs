using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_8
{
    
    class Program
    {
        static double func(double x)
        {
            return 2 * x - 4;
        }       
        static void Main(string[] args)
        {
            double x_begin, x_end,x;
            const double e = 0.01;
            x_begin = double.Parse(Console.ReadLine());
            x_end = double.Parse(Console.ReadLine());

            x = (x_begin + x_end) / 2;

            while (Math.Abs(func(x)) > e)
            {
                if (func(x) > 0)
                {
                    x_end = x;
                }
                else
                {
                    x_begin = x;
                }
                x = (x_begin + x_end) / 2;
            }

            
            Console.WriteLine(x);            
        }
    }
}
