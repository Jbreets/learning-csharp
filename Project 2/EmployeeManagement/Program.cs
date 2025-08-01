using System;

namespace EmployeeManagement
{
    class Program
    {   
        static void Main (string[] args)
        {   
            Console.WriteLine("\nWelcome to Employee Manager!\n");
            
            while(true) 
            {
            
            Console.WriteLine("\nWhat service do you need?\n");
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
                    Console.Write("Which user would you like to view (Provide ID): ");
                    int int3Temp = Convert.ToInt32(Console.ReadLine());
                    Options.Search(int3Temp);
                    break;
                case 4:
                    Console.Write("Which user would you like to Update (Provide ID): ");
                    int int4Temp = Convert.ToInt32(Console.ReadLine());
                    Options.Update(int4Temp);
                    break;
                case 5:
                    Console.Write("Which user would you like to Delete (Provide ID): ");
                    int int5Temp = Convert.ToInt32(Console.ReadLine());
                    Options.Delete(int5Temp);
                    break;
                case 6:
                    Options.Exit();
                    break;
                default:
                    break;
            }
            // Example of creation of new employee
            // EmployeeManagement.Employee emp1 = new Employee();
            // emp1.ID = 1;
            // emp1.name = "Jack";
            // emp1.age = 22;
            // emp1.job = "Web developer";
            // emp1.title = "Junior";
            // emp1.department = "Tech";
            }
        }
    }
}