using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var number = input.ToString();

            int size = number.ToString().Count();

            char[] elements = new char[size]; // contains digits from entered number
            var j = size - 1;

            for (var i = 0; i < size; i++)
            {                               
                elements[i] = number[j];
                j--;                   
            }

            double newNumber = double.Parse(new string(elements));            
            
            Console.Write("{0}", newNumber);
        }
    }
}
