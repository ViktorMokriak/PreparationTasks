using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    public class Bulb
    {
        public BulbStatus BulbStatus { get; set; }
        
        public Bulb()
        {
            BulbStatus = BulbStatus.Off;
        }

        public virtual void Print()
        {
            Console.WriteLine("Bulb is " + BulbStatus);
        } 
    }
}

