using System.Collections.Generic;

namespace EmployeeManagement
{
    public static class EmployeeStore
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee {ID = 1,name = "Jack",age = 22,job = "Web Dev",title = "Junior",department = "Tech"},
            new Employee {ID = 2,name = "Ash",age = 32,job = "Web Dev",title = "Junior",department = "Tech"},
            new Employee {ID = 3,name = "Nicole",age = 25,job = "Admin",title = "Junior",department = "Admin"},
            new Employee {ID = 4,name = "Phoebe",age = 21,job = "Rep",title = "Junior",department = "Admin"},
            new Employee {ID = 5,name = "Rach",age = 27,job = "Rep",title = "Junior",department = "Admin"}
        };  
    }
}