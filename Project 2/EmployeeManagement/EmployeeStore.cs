using System.Collections.Generic;

namespace EmployeeManagement
{
    public static class EmployeeStore
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee (1,"Jack", 22, "Web Dev", "Junior", "Tech"),
            new Employee (2,"Ash", 32, "Web Dev", "Junior", "Tech"),
            new Employee (3,"Nicole", 25, "Admin", "Junior", "Admin"),
            new Employee (4,"Phoebe", 21, "Rep", "Junior", "Admin"),
            new Employee (5,"Rach", 27, "Rep", "Junior", "Admin")
        };  
    }
}