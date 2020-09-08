using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_3
{    
    class Program
    {
        static void IncreaseValue(ref int val1, ref int val2, ref int val3)
        {
            val1 += 10;
            val2 += 10;
            val3 += 10;
        }

        static void Task2(out double square, out double circumference, double radius)
        {
            square = Math.Pow(radius, 2) * Math.PI;
            circumference = 2 * Math.PI * radius;
        }

        static void Task3(ref int[] arr,out int min,out int max,out int sum)
        {
            max = arr.Max();
            min = arr.Min();
            int result = 0;
            foreach(var i in arr)
            {
                result += i;
            }
            sum = result;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
