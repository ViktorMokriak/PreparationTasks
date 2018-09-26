using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PreparationTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            double lengthOfSideOrRadius;
            const float pi = 3.14f;
            double result;

            Console.WriteLine("Please, choose the figure and hit Enter:");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Triangle");

            double сhosenFigure = double.Parse(Console.ReadLine());

            if (сhosenFigure == 1)
            {
                Console.WriteLine("Please, input the length of the side of Square and hit Enter:");
                lengthOfSideOrRadius = double.Parse(Console.ReadLine());
                result = SurfaceAreaSquare(lengthOfSideOrRadius);
                Console.WriteLine("The surface area of the SQUARE is: " + result);
            }

            else
            {
                if (сhosenFigure == 2)
                {
                    Console.WriteLine("Please, input the length of the radius for Triangle and hit Enter:");
                    lengthOfSideOrRadius = double.Parse(Console.ReadLine());
                    result = SurfaceAreaTriangle(lengthOfSideOrRadius, pi);
                    Console.WriteLine("The surface area of the TRIANGLE is: " + result);
                }

                else
                {
                    Console.WriteLine("The input value is invalid.");
                }

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
