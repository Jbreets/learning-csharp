namespace EmployeeManagement
{
    public static class Options
    {   
        // Add employee Based off of given Parameter
        static public void Add()
        {
            Console.Write("What is the new user's Name? ");
            string usrName = Console.ReadLine();

            Console.Write("What is the new user's Age? ");
            string usrAge = Console.ReadLine();

            if (!int.TryParse(usrAge, out int newUsrAge))
            {
                Console.WriteLine("Invalid number for age.");
                return;
            }

            Console.Write("What is the new user's Job? ");
            string usrJob = Console.ReadLine();

            Console.Write("What is the new user's Title? ");
            string usrTitle = Console.ReadLine();

            Console.Write("What is the new user's Department? ");
            string usrDepartment = Console.ReadLine();

            // Prepare employee object
            var newEmployee = new Employee
            {
                ID = EmployeeStore.Employees.Count + 1,
                name = usrName,
                age = newUsrAge,
                job = usrJob,
                title = usrTitle,
                department = usrDepartment
            };

            // Show a summary before confirmation (optional but good UX)
            Console.WriteLine("\nEmployee Summary:");
            Console.WriteLine($"Name: {newEmployee.name}, Age: {newEmployee.age}, Job: {newEmployee.job}, Title: {newEmployee.title}, Department: {newEmployee.department}");

            Console.Write("Are you sure you want to add this user? (y/n): ");
            string yesNo = Console.ReadLine()?.ToLower();

            if (yesNo == "y")
            {
                EmployeeStore.Employees.Add(newEmployee);
                Console.WriteLine("Employee added!");
            }
            else
            {
                Console.WriteLine("No employee added.");
            }
        }

        // View full list of Employees
        static public void View()
        {   
            // Console.Write("Which ID are you searching for: ");
            foreach (var emp in EmployeeStore.Employees)
            {
                Console.WriteLine($"ID: {emp.ID} | Name: {emp.name} | Age: {emp.age} | Job: {emp.job} | Title: {emp.title} | Department: {emp.department}");
            }
        }
        // View employee in list based on ID
        static public void Search( int ID )
        {   
            bool found = false;
            foreach (var emp in EmployeeStore.Employees)
            {
                if (ID == emp.ID)
                {
                    Console.WriteLine($"ID: {emp.ID} | Name: {emp.name} | Age: {emp.age} | Job: {emp.job} | Title: {emp.title} | Department: {emp.department}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("User could not be found within the console :(");
            }
        }
        // View employee in list based on ID
        static public void Update( int ID)
        {   
            bool found = false;
            foreach(var emp in EmployeeStore.Employees) 
            {   
                if (ID == emp.ID)
                {   
                    Console.WriteLine("Fields you can change: name, age, job, title, department");
                    Console.Write("What field would you like to change: ");
                    
                    string usrField = Console.ReadLine().ToLower();

                    Console.Write($"What would you like to change the value to?");

                    string usrNewVal = Console.ReadLine();

                    switch (usrField)
                    {
                        case "name": emp.name = usrNewVal; break;
                        case "age":
                            if (int.TryParse(usrNewVal, out int newAge))
                                emp.age = newAge;
                            else
                                Console.WriteLine("Invalid number for age.");
                            break;
                        case "job": emp.job = usrNewVal; break;
                        case "title": emp.title = usrNewVal; break;
                        case "department": emp.department = usrNewVal; break;
                        default:
                            Console.WriteLine("Invalid field.");
                            break;
                    }
                    found = true;   
                }
            }
            if (!found)
            {
                Console.WriteLine("User not found.");
            }
        }
        // View employee in list based on ID
        static public void Delete( int ID )
        {
            // remove employee where ID is X


            Console.Write("Are you sure you want to remove this user? (y/n): ");
            string yesNo = Console.ReadLine()?.ToLower();

            if (yesNo == "y")
            {
                var empToRemove = EmployeeStore.Employees.FirstOrDefault(e => e.ID == ID);

                if (empToRemove != null)
                {
                    EmployeeStore.Employees.Remove(empToRemove);
                    Console.WriteLine("Employee removed.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else
            {
                Console.WriteLine("No employee added.");
            }
        }
        // Exit Program
        static public void Exit()
        {
            // Exits application
            System.Environment.Exit(0);
        }   
    }
}