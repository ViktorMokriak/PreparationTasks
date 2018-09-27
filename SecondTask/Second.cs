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
            double areaOfTriangle;

            //input the length of the side for SQUARE and length of the radius for the CIRCLE
            Console.WriteLine("Please, input the length of the square's side and hit Enter:");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, input the length of the radius for circle and hit Enter:");
            double radius = double.Parse(Console.ReadLine());

            //counting the surface area for both figures and showing results to console
            areaOfSquare = SurfaceAreaSquare(side);
            areaOfTriangle = SurfaceAreaTriangle(radius, pi);
            Console.WriteLine("The surface area of the SQUARE is: " + areaOfSquare);
            Console.WriteLine("The surface area of the CIRCLE is: " + areaOfTriangle);

            //calculating length of the side and radius from surface area of SQUARE and CIRCLE

            double sideFromSquare = Math.Sqrt(areaOfSquare);
            double radiusFromSquare = Math.Sqrt(areaOfTriangle/pi);

            //checking whether SQUARE can be placed inside CIRCLE

            if (sideFromSquare*Math.Sqrt(2)<=2*radiusFromSquare)
            {
                Console.WriteLine("SQUARE with length of the side " + sideFromSquare + " CAN BE placed inside CIRCLE with radius " + radiusFromSquare);
            }

            else
            {
                Console.WriteLine("SQUARE with length of the side " + sideFromSquare + " CAN NOT BE placed inside CIRCLE with radius " + radiusFromSquare);
            }


            //checking whether CIRCLE can be placed inside SQUARE 

            if (2*radiusFromSquare<=sideFromSquare)
            {
                Console.WriteLine("CIRCLE with length of the radius " + radiusFromSquare + " CAN BE placed inside SUQARE with side length " + sideFromSquare);
            }

            else
            {
                Console.WriteLine("CIRCLE with length of the radius " + radiusFromSquare + " CAN NOT BE placed inside SUQARE with side length " + sideFromSquare);
            }

        }


        public static double SurfaceAreaTriangle(double userInput, float pi)
        {
            return pi * Math.Pow(userInput, 2);
        }

        public static double SurfaceAreaSquare(double userInput)
        {
            return Math.Pow(userInput, 2);
        }



    }
}
