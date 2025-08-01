namespace EmployeeManagement
{
    public class Employee
    {    
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Job { get; set; }
    public string Title { get; set; }
    public string Department { get; set; }
    
    // Constructor class
    public Employee(int id, string name, int age, string job, string title, string department)
    {
        ID = id;
        Name = name;
        Age = age;
        Job = job;
        Title = title;
        Department = department;
    }

    }
}