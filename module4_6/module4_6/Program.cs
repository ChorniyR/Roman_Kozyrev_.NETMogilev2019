using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_6
{
    class Program
    {
        static void IncreaseElem(ref int[] arr)
        {
            for(var i = 0; i < arr.Length; i++)
            {
                arr[i] += 5;
            }            
        }
        static void Main(string[] args)
        {
      
        }
    }
}
