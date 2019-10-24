using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int current, previous1 = 0, previous2 = 0;  

            count = Int32.Parse(Console.ReadLine());

            for(var i = 0; i < count; i++)
            {
                current = previous1 + previous2;
                previous2 = previous1;
                previous1 = current;

                if(previous1 == 0)
                {
                    previous1 = 1;
                }

                Console.WriteLine("{0} ", current);
            }
        }
    }
}
