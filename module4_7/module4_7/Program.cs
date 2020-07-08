using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_7
{
    class Program
    {
        static void SortArray(bool IsAssendDirection, ref int[] arr)
        {
            if (IsAssendDirection)
            {
                var orderedNums = from i in arr
                                  orderby i
                                  select i;

                arr = orderedNums.ToArray();
            }
            else
            {
                var orderedNums = from i in arr
                                  orderby i descending
                                  select i;

                arr = orderedNums.ToArray();
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
