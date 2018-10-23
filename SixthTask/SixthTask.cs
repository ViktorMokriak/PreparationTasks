using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    class SixthTask

    {
        static void Main(string[] args)
        {
            int currentMinute = int.Parse(DateTime.Now.ToString("mm"));
            Console.WriteLine(currentMinute);
            Console.ReadLine();
        }
    }
}
