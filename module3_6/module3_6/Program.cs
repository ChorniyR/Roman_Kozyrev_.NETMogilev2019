using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random rnd = new Random();
            for(var i = 0;i< arr.Length; i++)
            {
                arr[i] = rnd.Next(-50, 50);
            }
           
            for (var i=0;i < arr.Length; i++)
            {
                    arr[i] *= -1;                                
            }            
        }
    }
}
