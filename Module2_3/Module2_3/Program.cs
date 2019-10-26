using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double number3;

            Console.WriteLine("Enter first number");
            bool success1 = double.TryParse(Console.ReadLine().Replace('.', ','), out double number1);
            Console.WriteLine("Enter second number");
            bool success2 = double.TryParse(Console.ReadLine().Replace('.', ','), out double number2);

            if ((success1) && (success2))
            {
                number3 = number1;
                number1 = number2;
                number2 = number3;

                Console.WriteLine("First number: {0}, second number: {1}", number1,number2);
            }
        }
    }
}
