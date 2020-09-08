using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_2
{
    class Program
    { 
        static int GetSum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static double GetSum(double num1,double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        static string GetLine(string str1, string str2)
        {
            var result = string.Concat(str1, str2);
            return result;
        }

        static int[] GetSum(int[] arr1, int[] arr2)
        {
            var len1 = arr1.Length;
            var len2 = arr2.Length;
            int[] result = new int[Math.Max(len1,len2)];

            var i = 0;
            while ((i < len1) && (i < len2))
            {
                result[i] = arr1[1] + arr2[i];
                i++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
