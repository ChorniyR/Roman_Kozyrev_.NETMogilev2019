using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_4
{
    class Program
    {
        static (int num1, int num2, int num3) GetSum(int num1, int num2, int num3)
        {
            var result = (num1+10, num2+10, num3+10);
            return result;
        }

        static (double square,double circum) GetCircleParams(double radius)
        {
            var circrleParams = (square: Math.PI*Math.Pow(radius,2), circumference: 2* Math.PI*radius);
            return circrleParams;
        }

        static (int max,int min,int sum) GetParams(int[] arr)
        {
            int min, max, sum = 0;

            max = arr.Max();
            min = arr.Min();
            foreach(var i in arr)
            {
                sum += i;
            }

            return (max, min, sum);            
        }

        static void Main(string[] args)
        {
            
        }
    }
}
