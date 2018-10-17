using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PreparationTasks
{
    public class First
    {
        static void Main(string[] args)
        {

            double lengthOfSideOrRadius;
            const float pi = 3.14f;
            double result;

            //selecting the figure

            Console.WriteLine("Please, choose the figure and hit Enter:");
            Console.WriteLine("1 - Square");
            Console.WriteLine("2 - Circle");

            double сhosenFigure = double.Parse(Console.ReadLine());

            //counting the surface area depending on selected figure

            if (сhosenFigure.Equals(1))
            {
                Console.WriteLine("Please, input the length of the side of Square and hit Enter:");
                lengthOfSideOrRadius = double.Parse(Console.ReadLine());
                result = CalculateAreaOfSquare(lengthOfSideOrRadius);
                Console.WriteLine("The surface area of the SQUARE is: " + result);
                Console.ReadLine();
            }

            else
            {
                if (сhosenFigure.Equals(2))
                {
                    Console.WriteLine("Please, input the length of the radius for Circle and hit Enter:");
                    lengthOfSideOrRadius = double.Parse(Console.ReadLine());
                    result = CalculateAreaOfCircle(lengthOfSideOrRadius, pi);
                    Console.WriteLine("The surface area of the CIRCLE is: " + result);
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("The input value is invalid.");
                    Console.ReadLine();
                }

            }

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
