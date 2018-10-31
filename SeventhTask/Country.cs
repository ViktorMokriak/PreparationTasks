using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhTask
{
    class Country
    {
        public string nameOfCountry { get; set; }
        public bool isTelenorSupported { get; set; }

        public Country(string line)
        {
            nameOfCountry = line;
            isTelenorSupported = false;
        }
    }
}
