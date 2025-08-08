using System;
namespace ToDoApp
{
    class Program
    {
        static void Main (string[] args) 
        {
        
            Console.Write("Would you like to view your tasks for the day? (y/n) \n");
            string yesNo = Console.ReadLine()!.ToLower();
            if (yesNo == "y")
            {
                TaskManager.ViewTasks();   
            }
            else
            {
                Console.WriteLine("Fair enough");
                System.Environment.Exit(0);
            }
        }
    }   
}