using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_1
{
    class Program
    {
        static double GetMaxValue(double[] arr)
        {
            double maxValue = arr.Max();

            return maxValue;
        }

        static double GetMinValue(double[] arr)
        {
            double minValue = arr.Min();

            return minValue;
        }

        static double GetSum(double[] arr)
        {
            double sum = 0;

            foreach(var i in arr)
            {
                sum += i;
            }

            return sum;
        }

        static double GetDifference(double[] arr)
        {
            var minValue = arr.Min();
            var maxValue = arr.Max();

            var differ = maxValue - minValue;

            return differ;
        }

        static void ChangeArray(double[] arr)  // increases the even elements by max value,reduces odd elements by min value  
        {
            var minValue = arr.Min();
            var maxValue = arr.Max();

            for(var i=0; i < arr.Length; i++)
            {
                if (i%2 == 0)
                {
                    arr[i] += maxValue;
                }
                else
                {
                    arr[i] -= minValue;
                }
            }
        }

        static void Main(string[] args)
        {
            double[] arr = new double[] { 1,4,3,9};

            ChangeArray(arr);
            foreach(var i in arr)
            {
               Console.Write("{0} ", i);
            }            
        }
    }
}
