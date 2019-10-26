using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            double tax;
            double income = 500;
            double total_tax;

            number = Int32.Parse(Console.ReadLine());
            tax = double.Parse(Console.ReadLine());

            total_tax = tax * number * income / 100;

            Console.WriteLine(total_tax);
        }
    }
}
