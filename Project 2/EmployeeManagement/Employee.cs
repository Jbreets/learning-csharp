namespace EmployeeManagement
{
    public class Employee : Person, IEmployeeActions
    {    
        public int ID { get; set; }
        private string _job = string.Empty;
        public string Job
        {
            get => _job;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Job cannot be empty.");
                _job = value;
            }
        }
        public Title Title { get; set; }
        public Department Department { get; set; }
    
    // Constructor class
        public Employee(int id, string name, int age, string job, Title title, Department department)
        : base(name, age)
        {
            ID = id;
            Job = job;
            Title = title;
            Department = department;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Job: {Job}, Title: {Title}, Department: {Department}");
        }

        public void Promote()
        {
            Console.WriteLine($"{Name} has been promoted!");
            Title = Title.Senior; // Example logic
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