using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
{
    class Program
    {

        static void Main(string[] args)
        {
            double triangleSquare,circleSquare,qadrandleSquare;
            double trianglePerimeter, circlePerimeter, qadrandlePerimeter;

            int computed;
            int figure;

            double side1,side2,side3;
            double altitude;

            double radius;

            double diagonal1, diagonal2;
            double angle;
            double qside1, qside2, qside3, qside4;

            Console.WriteLine("Enter 1/2 \n1: sqquare\n2: nperimeter");
            computed = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1/2/3 \n1: triangle\n2: circle\n3: qadrandle");
            figure = int.Parse(Console.ReadLine());

            if(computed == 1)
            {
                if(figure == 1)
                {
                    Console.WriteLine("Enter length of side");
                    side1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter altitude");
                    altitude = double.Parse(Console.ReadLine());

                    triangleSquare = 0.5 * side1 * altitude;

                    circleSquare = triangleSquare;

                    radius = Math.Sqrt(circleSquare / Math.PI);

                    Console.WriteLine("triangle square is: {0}\nCircle radius could be {1}", triangleSquare, radius);

                }
                else if (figure == 2)
                {
                    Console.WriteLine("Enter radius");
                    radius = double.Parse(Console.ReadLine());

                    circleSquare = Math.PI * Math.Pow(radius, 2);

                    Console.WriteLine("Circle square is {0}", circleSquare);
                }
                else if(figure == 3)
                {
                    Console.WriteLine("Enter diagonal");
                    diagonal1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter diagonal");
                    diagonal2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter angle");
                    angle = double.Parse(Console.ReadLine());

                    qadrandleSquare = 0.5 * diagonal1 * diagonal2 * Math.Sin(angle);

                    circleSquare = qadrandleSquare;

                    radius = Math.Sqrt(circleSquare / Math.PI);

                    Console.WriteLine("qadrandle square is: {0}\nCircle radius could be {1}", qadrandleSquare, radius);
                }
            }
            else
            {
                if (figure == 1)
                {
                    Console.WriteLine("Enter length of side");
                    side1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter length of side");
                    side2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter length of side");
                    side3 = double.Parse(Console.ReadLine());

                    trianglePerimeter = side1 + side2 + side3;

                    circlePerimeter = trianglePerimeter;

                    radius = circlePerimeter / (2 * Math.PI);

                    Console.WriteLine("Triangle perimeter is {0}\nCircle radius could be {1}", trianglePerimeter,radius);

                }
                else if (figure == 2)
                {
                    Console.WriteLine("Enter radius");
                    radius = double.Parse(Console.ReadLine());

                    circlePerimeter = 2 * Math.PI * radius;

                    Console.WriteLine("Circle perimeter is {0}", circlePerimeter);
                }
                else if (figure == 3)
                {
                    Console.WriteLine("Enter length of side");
                    qside1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter length of side");
                    qside2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter length of side");
                    qside3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter length of side");
                    qside4 = double.Parse(Console.ReadLine());

                    qadrandlePerimeter = qside1 + qside2 + qside3 + qside4;

                    circlePerimeter = qadrandlePerimeter;

                    radius = circlePerimeter / (2 * Math.PI);

                    Console.WriteLine("qadrandle perimeter is {0}\nCircle radius could be {1}", qadrandlePerimeter,radius);    
                }
            }
        }        
    }
}
