namespace EmployeeManagement
{
    public static class Options
    {   
        // Add employee Based off of given Parameter
        static public void Add()
        {
            EmployeeStore.Employees.Add(new Employee 
            {ID = 1,name = "Jack",age = 22,job = "Web Dev",title = "Junior",department = "Tech"});
            Console.WriteLine("Employee added!");
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
        static public void Search()
        {

        }
        // View employee in list based on ID
        static public void Update()
        {
        }
        // View employee in list based on ID
        static public void Delete()
        {
        }
        // Exit Program
        static public void Exit()
        {
            
        }   
    }
}