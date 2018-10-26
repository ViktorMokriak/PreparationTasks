using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    class ColoredGarland : Garland
    {
        public override void PrintStatusOfGarland()

        {
            for (int i = 0; i < NumberOfBulbs; i++)
            {
                Bulb newColoredBulb = new ColoredBulb ();
                bulbs.Add(newColoredBulb);
            }

            int currentMinute = int.Parse(DateTime.Now.ToString("mm"));
            Console.WriteLine("Current minute is: " + currentMinute);
            for (int i = 0; i < bulbs.Count; i++)
            {
                if ((currentMinute % 2).Equals(0) && (i % 2).Equals(0) || (!(currentMinute % 2).Equals(0) && !(i % 2).Equals(0)))
                {
                    bulbs[i].BulbStatus = BulbStatus.On;
                }

                ((ColoredBulb)bulbs[i]).BulbColor = (BulbColor)((i + 1) % 4);

                Console.WriteLine("Bulb № " + i + " is " + bulbs[i].BulbStatus + " " + ((ColoredBulb)bulbs[i]).BulbColor);
            }
        }
    }
}   
