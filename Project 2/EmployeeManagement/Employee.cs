namespace EmployeeManagement
{
    public class Employee : Person
    {    
        public int ID { get; set; }
        // public string Name { get; set; }
        // public int Age { get; set; }
        public string Job { get; set; }
        public Title Title { get; set; }
        public Department Department { get; set; }
    
    // Constructor class
        public Employee(int id, string name, int age, string job, Title title, Department department)
        : base(name, age)
        {
            ID = id;
            Name = name;
            Age = age;
            Job = job;
            Title = title;
            Department = department;
        }
    }

    // Enums - Look at GPT for basics on how to implement these
    public enum Department 
    {
        Tech,
        HR,
        Admin,
        Sales,
        Marketing
    }
        public enum Title 
    {
        Junior,
        Mid,
        Senior,
        Lead
    }
}