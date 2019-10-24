using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Int32.Parse(Console.ReadLine());
            string number = input.ToString();
            int size = number.Length;

            char[] symbhol = Console.ReadLine().ToCharArray();
            char[] elements = new char[size];

            int j = 0;
            for (var i = 0; i < number.Length; i++)
            {                
                if (number[i] != symbhol[0])
                {
                    elements[j] = number[i];
                    j++;
                }            
            }

            int newNumber =int.Parse(new string(elements));
            
            Console.WriteLine(newNumber);
        }
    }
}
