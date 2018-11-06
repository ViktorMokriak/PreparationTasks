using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    public class SixthTask

    {
        public static void Main(string[] args)
        {
            //input number of bulbs
            Console.WriteLine("Please, input length of Garland");
            int numberOfBulbs = int.Parse(Console.ReadLine());

            int currentMinute = int.Parse(DateTime.Now.ToString("mm"));
            Console.WriteLine("Current minute is: " + currentMinute);

            // printing of simple garland
            Console.WriteLine("-----Simple Garland-----");
            SimpleGarland simpleGarland = new SimpleGarland(numberOfBulbs);
            simpleGarland.TurnOnBulb(currentMinute);
            simpleGarland.PrintStatusOfGarland();
            Console.ReadKey();

            // printing of colored garland
            Console.WriteLine("-----Colored Garland-----");
            ColoredGarland coloredGarland = new ColoredGarland(numberOfBulbs);
            coloredGarland.TurnOnBulb(currentMinute);
            coloredGarland.PrintStatusOfGarland();
            Console.ReadKey();
        }
    }
}
