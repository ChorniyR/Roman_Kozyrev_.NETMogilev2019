using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rnd = new Random();
            
            for(var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 20);
            }

            foreach(var i in numbers)
            {
                Console.Write("{0} ",i);
            }

            Console.WriteLine();

            for (var i = 0; i < numbers.Length-1; i++)
            {
                if(numbers[i] > numbers[i+1])
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }            
        }
    }
}
