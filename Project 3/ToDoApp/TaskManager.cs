using System.Reflection;
namespace ToDoApp
{
    class TaskManager
    {
        static public void ViewTasks() 
        {
            foreach (var task in TaskStore.TaskItems)
            {
                Console.WriteLine($"{task.ID}, {task.Description}, {task.DueDate}, {task.Priority}, {task.Status}," );
            }
        }
        // Add new task Method
        static public void AddTask()
        {
            Console.Write("What is this task? ");
            string NewTaskDescription = Console.ReadLine()!;
            Console.WriteLine("Date format = dd/mm/yyyy");
            Console.Write("When is this task due ");
            string NewTaskDateDue = Console.ReadLine()!;
            DateTime NewDateDue;
            DateTime.TryParse(NewTaskDateDue, out NewDateDue);
            Console.WriteLine("Available Priorities: low | medium | high | urgent");
            Console.Write("What priority is this task? ");
            string NewTaskPriority = Console.ReadLine()!;
            if (!Enum.TryParse(NewTaskPriority, true, out Priority NewPriority))
            {
                Console.WriteLine("Invalid Priority");
            }
            Console.WriteLine("Available statuses: pending | underway | complete");
            Console.Write("What is the current status of the task ");
            string NewTaskStatus = Console.ReadLine()!;
            if (!Enum.TryParse(NewTaskStatus, true, out Status NewStatus))
            {
                Console.WriteLine("Invalid Priority");
            }

            var task = new TaskItem
            (
                TaskStore.TaskItems.Count+1, NewTaskDescription, NewDateDue, NewPriority, NewStatus
            );
            TaskStore.TaskItems.Add(task);
        }
        // Update task Method
        static public void UpdateTask(int ID)
        {       
            foreach (var task in TaskStore.TaskItems)
            {
                if (ID == task.ID)
                {
                    Console.WriteLine("Fields you can change: Description, Due, Priority, Status");
                    Console.Write("What field would you like to update:");
                    string UserResponse = Console.ReadLine()!.ToLower();
                    switch (UserResponse)
                    {
                        case "description":
                            Console.WriteLine("");
                            break;
                        case "due":
                            break;
                        case "priority":
                            break;
                        case "status":
                            break;
                        default:
                            Console.WriteLine("Input doesn't match any given field");
                            break;
                    }
                }
            }
        }
        // Exit TodoList Method
        static public void Exit()
        {
            Console.WriteLine("Come back soon");
            System.Environment.Exit(0);
        }
    }
}