﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    class Fourth
    {
        static void Main(string[] args)
        {

            //input the word from the keyboard and convert it to array of chars
            Console.WriteLine("Please, input the word: ");

            string inputWord = Convert.ToString(Console.ReadLine());
            char[] array = inputWord.ToCharArray();

            Console.WriteLine("Input word - " + (IsPalindrom(array) ? "" : "NOT") + " PALINDROM");
            Console.ReadLine();
        }

        static bool IsPalindrom(char[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
