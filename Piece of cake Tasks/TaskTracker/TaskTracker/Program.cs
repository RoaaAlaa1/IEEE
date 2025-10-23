using System.Reflection.Metadata;

namespace TaskTracker
{

    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskIndex = 0;
        static void Main(string[] args)
        {
            string userChoice = "";
            Console.WriteLine("Welcome to your Task Tracker! \n\n");
            

            do
            {
                Console.WriteLine("Enter the number of your perfered action: ");
                Console.WriteLine("\n1. Add a new task \n2. View your current tasks \n3. Mark your task/s complete \n4. Remove a task \n5. Exit :(\n");

                userChoice = Console.ReadLine();
                if (userChoice == "5")
                {
                    Console.WriteLine("See you later :)");
                    break;
                }

                switch (userChoice)
                    {
                        case "1":
                            AddTask(tasks);
                            break;
                        case "2":
                            ViewTask();
                            break;

                        case "3":
                            MarkComplete();
                            break;

                        case "4":
                            RemoveTask();
                            break;

                        default:
                            Console.WriteLine("Choose from 1-5 only plz :)");
                            break;
                    }

            } while (userChoice != "5");
            



        }

        private static void AddTask(string[] tasks)
        {
            Console.WriteLine("Enter your task plz :) : ");

            string newTask = Console.ReadLine();
            tasks[taskIndex] = newTask;

            Console.WriteLine("\nTask added! ^^");
            Console.WriteLine("__________________________");
            taskIndex++;
        }

        private static void ViewTask()
        {
            Console.WriteLine("\nYour current tasks: ");

            for (int i =0; i < taskIndex; i++)
            {
                Console.WriteLine($"{i+1} {tasks[i]} ");
                Console.WriteLine("__________________________\n");
            }
        }

        private static void MarkComplete()
        {
            Console.WriteLine("Enter task number: ");
            string taskorder = Console.ReadLine();

            int taskNUM = Convert.ToInt32(taskorder);

            tasks[taskNUM-1] = tasks[taskNUM-1] + "  (Completed! ^-^)"; //leh -1? ex: user = 1 that means index 0, like what's infront of him

        }
        private static void RemoveTask()
        {
            Console.WriteLine("Enter the number of the task you want removed: ");
            string removed = Console.ReadLine();

            int removedTask = Convert.ToInt32(removed);

            tasks[removedTask-1] = string.Empty;

        }
    }
}