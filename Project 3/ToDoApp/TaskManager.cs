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
        static public void AddTask()
        {

            Console.Write("What is this task? ");
            string NewTaskDescription = Console.ReadLine()!;
            Console.Write("When is this task due ");
            string NewTaskDateDue = Console.ReadLine()!;
            DateTime NewDateDue;
            DateTime.TryParse(NewTaskDateDue, out NewDateDue);
            Console.Write("What priority is this task? ");
            string NewTaskPriority = Console.ReadLine()!;
            if (!Enum.TryParse(NewTaskPriority, true, out Priority NewPriority))
            {
                Console.WriteLine("Invalid Priority");
            }
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

            // var task = new TaskItem
            // (
                // 6, "Finish ToDoApp", DateTime.Today, Priority.Medium, Status.Underway 
            // );
            // TaskStore.TaskItems.Add(task);
        }
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

        static public void Exit()
        {
            System.Environment.Exit(0);
        }

    }
}