namespace ToDoApp
{
    public static class TaskStore
    {
        public static List<TaskItem> TaskItems = new List<TaskItem>
        {
            new TaskItem(1, "Check emails", DateTime.Today, Priority.Urgent, Status.Complete),
            new TaskItem(2, "DuoLingo", DateTime.Today, Priority.High, Status.Complete),
            new TaskItem(3, "Go to the Gym", DateTime.Today, Priority.Medium, Status.Pending),
            new TaskItem(4, "Work / studying", DateTime.Today, Priority.Medium, Status.Underway),
            new TaskItem(5, "Edit todo list for tomorrow", DateTime.Today, Priority.Low, Status.Pending)
        };
    }
}