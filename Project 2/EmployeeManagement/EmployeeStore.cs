using System.Collections.Generic;

namespace EmployeeManagement
{
    public static class EmployeeStore
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee (1,"Jack", 22, "Web Dev", Title.Junior, Department.HR),
            new Employee (2,"Ash", 32, "Web Dev", Title.Junior, Department.HR),
            new Employee (3,"Nicole", 25, "Admin", Title.Junior, Department.HR),
            new Employee (4,"Phoebe", 21, "Rep", Title.Junior, Department.HR),
            new Employee (5,"Rach", 27, "Rep", Title.Junior, Department.HR)
        };  
    }
}