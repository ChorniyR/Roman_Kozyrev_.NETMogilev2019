using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_5
{
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

    enum Months
    {
        January = 31,
        February = 28,
        March = 31,
        April = 30,
        May = 31,
        June = 30,
        July = 31,
        August = 31 ,
        September= 30,
        October = 31,
        November = 30 ,
        December = 31,
    }
    class Program
    {
        static double MathOp(double num1,double num2, Operation op)
        {
            double result = 0;
            switch (op)
            {
                case Operation.Add:
                    result = num1 + num2;
                    break;
                case Operation.Divide:
                    result = num1 - num2;
                    break;
                case Operation.Multiply:
                    result = num1 * num2;
                    break;
                case Operation.Subtract:
                    result = num1 / num2;
                    break;
            }
            return result;
        }

        static int GetDaysCount(Months mons)
        {
            var days = (int)mons;
            return days;
        }
        static void Main(string[] args)
        {

        }
    }
}
