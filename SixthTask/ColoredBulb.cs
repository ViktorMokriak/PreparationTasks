using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    public class ColoredBulb : Bulb
    {
        public BulbColor BulbColor { get; set; }

        public ColoredBulb(BulbColor color) : base()
        {
            BulbColor = color;
        }

        public ColoredBulb()
        {
            BulbColor = BulbColor.Blue;
        }

        public override void Print()
        {
            Console.WriteLine("Bulb is " + BulbStatus + " " + BulbColor);
        }
    }
}
