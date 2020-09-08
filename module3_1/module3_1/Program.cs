using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            int result = 0;
            bool minus = false;

            for (var i = 0; i < Math.Abs(number2); i++)
            {
                result += Math.Abs(number1);
            }

            if ((number1 < 0) || (number2 < 0))
            {
                minus = true;
            }

            if (number1 < 0 && number2 < 0)
            {
                minus = false;
            }

            if (minus)
            {
                result *= -1;
            }
            Console.WriteLine("{0} ", result);
        }
    }
}
