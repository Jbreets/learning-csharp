using System;
using System.Collections;
using System.Diagnostics;
namespace ToDoApp
{
    class Program
    {
        static void Main (string[] args) 
        {           
            //Console.Write("Would you like to view your tasks for the day? (y/n) \n");
            //string yesNo = Console.ReadLine()!.ToLower();
            //if (yesNo == "n")
            //{
            //    Console.WriteLine("Fair enough");
            //    System.Environment.Exit(0);   
            //}
            //else
            //{}
            Console.WriteLine("Start of program");
            while (true)
            {
                Console.Write("Which action would you like to perform: \n-add: Add task \n-view: View tasks \n-update: Update task via ID\n-exit: Exit\n");
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
                        Console.Write("Provide ID");                        
                        int TaskID = Convert.ToInt32(Console.ReadLine());
                        TaskManager.UpdateTask(TaskID);
                        break;
                    case "exit":
                        TaskManager.Exit();
                        break;
                    default:
                        Console.WriteLine("Input doesn't match any given field");
                        break;
                };
            }
        }
    }   
}