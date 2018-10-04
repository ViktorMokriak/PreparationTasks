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

            int timeForAllTasks = 0;
            int counter = 0;
            int nDays;
            int nHours;

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

            //calculation of the time needed to complete all tasks
            foreach (Task task in tasks)
            {
                timeForAllTasks += task.Complexity;
            }

            Console.WriteLine("Total amount of hours needed to execute all tasks is: " + timeForAllTasks);


            //list of tasks for a certain priority (entered from keyboard)
            Console.WriteLine("Please, specify the PRIORITY of tasks to be shown.\n1 - for HIGH;\n2 - for MEDIUM;\n3 - for LOW");
            int priority = int.Parse(Console.ReadLine());

            foreach (Task task in tasks)
                
                if (task.Priority == priority)
                {
                    counter = tasks.Count(); //counting the quantity of tasks with selected PRIORITY
                }
            
                if (counter == 0)
                {
                    Console.WriteLine("There is no tasks in the LIST with selected PRIORITY.");
                }

                else 
                {
                    Console.WriteLine("List of TASKS with selected PRIORITY:");
                    foreach (Task task in tasks)

                        if (task.Priority == priority)
                        {
                            Console.WriteLine(task.NameOfTask);
                        }
                
                }


            //how many tasks can be performed per N days

            Console.WriteLine("Please, input N of days:");
            nDays = int.Parse(Console.ReadLine());
            nHours = nDays * 8;
            int temp = 0;
           
            List<Task> SortedByPriority = tasks.OrderBy(o => o.Priority).ThenBy(o => o.Complexity).ToList(); //sort by PRIORITY

            Console.WriteLine("List of tasks per N days based on PRIORITY:");
            foreach (Task task in SortedByPriority)
            {
                temp += task.Complexity;

                if (temp <= nHours)
                {
                    Console.WriteLine(task.NameOfTask);
                }

                else
                {
                    break;
                }

            }

        }
    }
}
