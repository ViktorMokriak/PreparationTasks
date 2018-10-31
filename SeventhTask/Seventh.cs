using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhTask
{
    class Seventh
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\vilto\Desktop\countries.txt";
            Dictionary<int, Country> countries = new Dictionary<int, Country>();

            try
            {
                Console.WriteLine();
                Console.WriteLine("-----All countries of European Union-----");
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    int temp=0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Country country = new Country(line);

                        countries.Add(temp, country);
                        temp++;
                    }
                }
                
                foreach (Country country in countries.Values)
                {
                    Console.WriteLine(country.nameOfCountry);
                }


            //    foreach (KeyValuePair<int, string> keyValue in countries)
            //    {
            //        Console.WriteLine(Country.);
            //    }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}