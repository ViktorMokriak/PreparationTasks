using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Third
    {
        static void Main(string[] args)
        {
            int arrLength;
            int resultSum=0;

            //entering the length of the array and checking whether it's longer than 10
            Console.WriteLine("Please, input the length of array (more than 10):");

            arrLength = Convert.ToInt32(Console.ReadLine());
            if (arrLength <= 10)
            {
                Console.WriteLine("The input length should be more than 10.");
            }
            else
            {
                //initializing the array from keyboard input
                int[] array = new int[arrLength];
                int i = 0;
                while (i < arrLength)
                {
                    Console.WriteLine("Please, input element of array and hit Enter");
                    array[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    i++;
                }

                //printing the input array to console
                for (i = 0; i < arrLength; i++)
                Console.WriteLine("Element[" + i + "]: " + array[i]);
                Console.ReadKey();

                //check the main condition of the task and showing the result
                for (i = 0; i < arrLength; i++)

                    if (array[i] % 3 == 0 && array[i] % 5 != 0)
                    {
                        resultSum = resultSum + array[i];
                    }

                Console.WriteLine("The SUM of array elements that are divided to 3 but not divisible to 5 is " + resultSum);
                Console.ReadKey();

            }   

        }
    }
}
