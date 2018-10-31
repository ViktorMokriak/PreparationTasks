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
            string path = @"C:\Users\ViktorM\Desktop\countries.txt";
            //string path = @"C:\Users\vilto\Desktop\countries.txt";
            Dictionary<int, Country> countries = new Dictionary<int, Country>();
          
            Console.WriteLine("-----List of European Union countries with Ukraine-----");
            Console.WriteLine();
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

            //addind Ukraine to the dictionary
            countries.Add(countries.Count + 1, new Country("Ukraine"));

               //print list of European Union countries with Ukraine
               foreach (Country country in countries.Values)
               {
                   Console.WriteLine(country.nameOfCountry);
               }

            //print list of Countries where Telenor is supported
            Console.WriteLine();
            Console.WriteLine("-----List of European Union countries with Ukraine where Telenor is not supported-----");
            Console.WriteLine();
            foreach (Country country in countries.Values)
               {
                   if (country.nameOfCountry.Equals("Denmark") || country.nameOfCountry.Equals("Hungary")) 
                   {
                       country.isTelenorSupported = true;
                   }

                   if (country.isTelenorSupported == false)
                   {
                       Console.WriteLine(country.nameOfCountry);
                   }
               }
           
            Console.ReadLine();
        }
    }
}