using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Second
    {
        static void Main(string[] args)
        {
            
            const float pi = 3.14f;
            double areaOfSquare;
            double areaOfCircle;

            //input the length of the side for SQUARE and length of the radius for the CIRCLE
            Console.WriteLine("Please, input the length of the square's side and hit Enter:");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, input the length of the radius for circle and hit Enter:");
            double radius = double.Parse(Console.ReadLine());

            //counting the surface area for both figures and showing results to console
            areaOfSquare = CalculateAreaOfSquare(side);
            areaOfCircle = CalculateAreaOfCircle(radius, pi);
            Console.WriteLine("The surface area of the SQUARE is: " + areaOfSquare);
            Console.WriteLine("The surface area of the CIRCLE is: " + areaOfCircle);

            //calculating length of the side and radius from surface area of SQUARE and CIRCLE

            double sideFromSquare = Math.Sqrt(areaOfSquare);
            double radiusFromSquare = Math.Sqrt(areaOfCircle/pi);

            Console.WriteLine("CIRCLE with length of the radius " + radiusFromSquare +
                    " CAN " + (CircleInsideSquare(radius, side) ? "" : "NOT") +
                    " BE placed inside SUQARE with side length " + sideFromSquare);
           
            Console.WriteLine("SQUARE with length of the side " + sideFromSquare +
                    " CAN " + (SquareInsideCircle(radius, side) ? "" : "NOT") +
                    " BE placed inside CIRCLE with radius " + radiusFromSquare);
            Console.ReadLine();
        }


        public static bool CircleInsideSquare(double radiusFromSquare, double sideFromSquare)
        {
            return 2 * radiusFromSquare <= sideFromSquare;
        }

        public static bool SquareInsideCircle(double radiusFromSquare, double sideFromSquare)
        {
            return sideFromSquare * Math.Sqrt(2) <= 2 * radiusFromSquare;
        }
        
        public static double CalculateAreaOfCircle(double userInput, float pi)
        {
            return pi * Math.Pow(userInput, 2);
        }

        public static double CalculateAreaOfSquare(double userInput)
        {
            return Math.Pow(userInput, 2);
        }
    }
}
