using System;

namespace EmployeeManagement
{
    class Program
    {   
        static void Main (string[] args)
        {   
            Console.WriteLine("\nWelcome to Employee Manager!\n");

            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exit\n");

            Console.Write("Choose an option: ");

            double option;
            double.TryParse(Console.ReadLine(), out option);

            switch (option) {
                case 1:
                    Options.Add();
                    break;
                case 2:
                    Options.View();
                    break;
                case 3:
                    Options.Search();
                    break;
                case 4:
                    Options.Update();
                    break;
                case 5:
                    Options.Delete();
                    break;
                case 6:
                    Options.Exit();
                    break;
                default:
                    break;
            }
            // Example of creation of new employee
            EmployeeManagement.Employee emp1 = new Employee();
            emp1.ID = 1;
            emp1.name = "Jack";
            emp1.age = 22;
            emp1.job = "Web developer";
            emp1.title = "Junior";
            emp1.department = "Tech";
        }
    }

    public class Employee
    {
        public int  ID;
        public string name;
        public int age;
        public string job;
        public string title;
        public string department;
    }
}