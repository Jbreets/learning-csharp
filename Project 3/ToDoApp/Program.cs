using System;
using System.Collections;
using System.Diagnostics;
namespace ToDoApp
{
    class Program
    {
        static void Main (string[] args) 
        {   
            // Logs
            TaskManager.TaskAdded += task => 
            Console.WriteLine($"[LOG] Task Added: {task.Description}");
            TaskManager.TaskRemoved += task => 
            Console.WriteLine($"[LOG] Task Removed: {task.Description}");
            TaskManager.TaskUpdated += task => 
            Console.WriteLine($"[LOG] Task Updated: {task.Description}");

            // Main program
            Console.WriteLine("Start of program");
            while (true)
            {
                Console.WriteLine("Which action would you like to perform:");
                Console.WriteLine("Terminal Command |   Function\n");
                Console.WriteLine("-add             :   Add task");
                Console.WriteLine("-view            :   View tasks");
                Console.WriteLine("-view urgent     :   View Urgent Tasks");
                Console.WriteLine("-update          :   Update task via ID");
                Console.WriteLine("-remove          :   Remove Task");
                Console.WriteLine("-exit            :   Exit\n");
                Console.Write("-");

                string UserAction = Console.ReadLine()!.ToLower();
                switch(UserAction)
                {
                    case "add":
                        TaskManager.AddTask();
                        break;
                    case "view":
                        TaskManager.ViewTasks();
                        break;
                    case "update":
                        Console.Write("Provide ID: ");                        
                        int TaskID = Convert.ToInt32(Console.ReadLine());
                        TaskManager.UpdateTask(TaskID);
                        break;
                    case "remove":
                        Console.Write("Provide ID: ");
                        int RemoveID = Convert.ToInt32(Console.ReadLine());
                        TaskManager.RemoveTask(RemoveID);
                        break;
                    case "view urgent":
                        TaskManager.ViewUrgentTasks();
                        break;
                    case "exit":
                        TaskManager.Exit();
                        break;
                    default:
                        Console.WriteLine("Input doesn't match any given field");
                        break;
                };
            
            Console.Write("Perform another command?(y/n) ");
            string YesNo = Console.ReadLine()!;
            if (YesNo == "n") { TaskManager.Exit(); }
            }
        }
    }   
}