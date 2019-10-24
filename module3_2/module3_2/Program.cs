using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;

            number1 = Int32.Parse(Console.ReadLine());
            
            for(var i=0; i < number1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
