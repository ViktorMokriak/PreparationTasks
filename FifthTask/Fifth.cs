using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    class Fifth
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Please, input the number of TASKS to be added:");
            int numberOfTasks = int.Parse(Console.ReadLine());

            List<Task> tasks = new List<Task>();

            
            for (int i = 0; i < numberOfTasks; i++)
            {
                Task newTask = new Task();
                Console.WriteLine("Please, input the name of Task №: " + (i+1));
                newTask.NameOfTask = Console.ReadLine();

                Console.WriteLine("Please, input the PRIORITY for Task №: " + (i + 1) + ".\n" + "1 - for HIGH;\n" + "2 - for MEDIUM;\n" + "3 - for LOW");
                newTask.Priority = int.Parse(Console.ReadLine());

                Console.WriteLine("Please, input the COMPLEXITY of Task №: " + (i + 1) + ".\n" + "4 - for DIFFICULT;\n" + "2 - for MEDIUM;\n" + "1 - for EASY");
                newTask.Complexity = int.Parse(Console.ReadLine());
                tasks.Add(newTask);
            }

            //сколько всего времени нужно для выполнения всех задач
            int timeForAllTasks = 0;
            foreach (Task task in tasks)
            {
                timeForAllTasks += task.Complexity;
            }

            Console.WriteLine("Total amount of hours needed to execute all tasks is: " + timeForAllTasks);


            //список задач заданного приоритета (приоритет ввести с клавиатуры)

            Console.WriteLine("Please, input the number of TASKS to be added:");
            //int numberOfTasks = int.Parse(Console.ReadLine());






        }
    }
}
