namespace ToDoApp
{
    public record TaskItem
    {   
        // Variable initiation
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        
        // constructor
        public TaskItem(int id, string description, DateTime duedate, Priority priority, Status status)
        {
            ID = id;
            Description = description; 
            DueDate = duedate;
            Priority = priority; 
            Status = status;
        }
    }
    public enum Priority {Urgent,High,Medium,Low}
    public enum Status{Complete,Underway,Pending}
    public enum TaskActions{add,view,update,exit};
}