using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = Int32.Parse(Console.ReadLine());

            if((number%2==0) && (number >= 18))
            {
                Console.WriteLine("Сongratulate! You are adult");
            }
            else if((number%2!=0) && (number < 18) && (number > 13))
            {
                Console.WriteLine("Сongratulate with your going to hight school!");
            }
        }
    }
}
