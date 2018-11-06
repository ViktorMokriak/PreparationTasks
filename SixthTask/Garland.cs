using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SixthTask
{
    public abstract class Garland<T> where T: Bulb, new()
    {
        protected List<T> bulbs = new List<T>();
        public int NumberOfBulbs { get; set; }
 
        //initializing of the Garland
        public Garland (int NumberOfBulbs)
        {
            this.NumberOfBulbs = NumberOfBulbs;
            for (int i = 0; i < NumberOfBulbs; i++)
            {
                T newBulb = new T();
                bulbs.Add(newBulb);
            }
        }

        //turn on the particular bulbs
        public void TurnOnBulb (int currentMinute)
        {
            for (int i = 0; i < bulbs.Count; i++)
            {
                if (((currentMinute % 2).Equals(0) && (i % 2).Equals(0)) || (!(currentMinute % 2).Equals(0) && !(i % 2).Equals(0)))
                {
                    bulbs[i].BulbStatus = BulbStatus.On;
                }
         
            }
        }

        public void PrintStatusOfGarland()
        {
            foreach (Bulb bulb in bulbs)
            {
                 bulb.Print();
            }
        }
    }
}
