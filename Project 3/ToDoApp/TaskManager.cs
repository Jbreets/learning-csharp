using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
namespace ToDoApp
{
    class TaskManager
    {
        // Methods
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
            TaskAdded?.Invoke(task);
        }
        // Update task Method
        static public void UpdateTask(int ID)
        {       
            foreach (var task in TaskStore.TaskItems)
            {
                if (ID == task.ID)
                {
                    Console.WriteLine("Fields you can change: Description, Due, Priority, Status");
                    Console.Write("What field would you like to update: ");
                    string UserResponse = Console.ReadLine()!.ToLower();
                    switch (UserResponse)
                    {
                        case "description":
                            Console.Write("Updated description: ");
                            string UpDescription = Console.ReadLine()!;
                            task.Description = UpDescription;
                            TaskUpdated?.Invoke(task);
                            break;

                        case "due":
                            Console.WriteLine("Date formate (DD/MM/YYYY)");
                            Console.Write("New due date: ");
                            string ReadDue = Console.ReadLine()!;
                            DateTime UpDue;
                            DateTime.TryParse(ReadDue, out UpDue);
                            task.DueDate = UpDue;
                            TaskUpdated?.Invoke(task); 
                            break;

                        case "priority":
                            Console.Write("Updated description: ");
                            string ReadPriority = Console.ReadLine()!;
                            if (!Enum.TryParse(ReadPriority, true, out Priority UpPriority))
                            {
                                Console.WriteLine("Invalid Priority");
                            }
                            task.Priority = UpPriority;
                            TaskUpdated?.Invoke(task);
                            break;

                        case "status":
                            // turn this into an object upgrade method
                            Console.Write("updated status: ");
                            string ReadStatus = Console.ReadLine()!;
                            if (!Enum.TryParse(ReadStatus, true, out Status UpStatus))
                            {
                                Console.WriteLine("Invalid Priority");
                            }
                            task.Status = UpStatus;
                            TaskUpdated?.Invoke(task);
                            break;

                        default:
                            Console.WriteLine("Input doesn't match any given field");
                            break;
                    }
                }
            }
        }
        static public void RemoveTask(int ID)
        {
            var TaskToRemove = TaskStore.TaskItems.FirstOrDefault(t => t.ID == ID);
            
            if (TaskToRemove != null) 
            {
                Console.WriteLine($"Removeing {TaskToRemove.ID}, {TaskToRemove.Description}, {TaskToRemove.DueDate}, {TaskToRemove.Priority}, {TaskToRemove.Status}");
                TaskStore.TaskItems.Remove(TaskToRemove);
                TaskRemoved?.Invoke(TaskToRemove);
            }  
            else
            {
                Console.WriteLine("Task not found");
            }

        }
        // Exit TodoList Method
        static public void Exit()
        {
            Console.WriteLine("Come back soon");
            System.Environment.Exit(0);
        }
        static public void ViewUrgentTasks() 
        {   
            Console.WriteLine("Current Urgent Tasks");
            var UrgentTasks = TaskStore.TaskItems
            .Where(t => t.Priority == Priority.Urgent && t.Status != Status.Complete )
            .OrderBy(t => t.DueDate);

            foreach (var item in UrgentTasks)
            {
                Console.WriteLine($"{item.Description}, {item.DueDate}, {item.Priority}, {item.Status}");
            }

        }
        
        // Events
        public static event Action<TaskItem>? TaskAdded;
        public static event Action<TaskItem>? TaskRemoved;
        public static event Action<TaskItem>? TaskUpdated;
    }
}