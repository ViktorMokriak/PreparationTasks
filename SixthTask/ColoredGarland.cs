using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    public class ColoredGarland : Garland<ColoredBulb>
    {
        public ColoredGarland(int NumberOfBulbs) : base(NumberOfBulbs)
        {
            for (int i = 0; i < bulbs.Count; i++)
            {
                bulbs[i].BulbColor = (BulbColor)((i + 1) % 4);
            }
        }
    }
}   
