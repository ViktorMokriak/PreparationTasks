using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SixthTask
{
    public abstract class Garland
    {
        protected List<Bulb> bulbs = new List<Bulb>();
        public int NumberOfBulbs { get; set; }

        public virtual void PrintStatusOfGarland()
  
        {
            foreach (var bulb in bulbs)
                Console.WriteLine();
        }
      
    }
}
