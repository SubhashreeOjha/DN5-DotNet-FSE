using System;

class Task
{
    public int TaskId;
    public string TaskName;
    public string Status;
    public Task Next;

    public Task(int id, string name, string status)
    {
        TaskId = id;
        TaskName = name;
        Status = status;
        Next = null;
    }
}

class TaskLinkedList
{
    private Task head;

    public void AddTask(int id, string name, string status)
    {
        Task newTask = new Task(id, name, status);

        if (head == null)
        {
            head = newTask;
            return;
        }

        Task temp = head;

        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newTask;
    }

    public void TraverseTasks()
    {
        Task temp = head;

        while (temp != null)
        {
            Console.WriteLine(
                $"{temp.TaskId} {temp.TaskName} [{temp.Status}]");
            temp = temp.Next;
        }
    }

    public void SearchTask(int id)
    {
        Task temp = head;

        while (temp != null)
        {
            if (temp.TaskId == id)
            {
                Console.WriteLine(
                    $"Found: {temp.TaskId} {temp.TaskName}");
                return;
            }

            temp = temp.Next;
        }

        Console.WriteLine("Task not found");
    }

    public void DeleteTask(int id)
    {
        if (head == null)
            return;

        if (head.TaskId == id)
        {
            head = head.Next;
            return;
        }

        Task temp = head;

        while (temp.Next != null &&
               temp.Next.TaskId != id)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        TaskLinkedList tasks = new TaskLinkedList();

        tasks.AddTask(1, "Design UI", "Pending");
        tasks.AddTask(2, "Write Code", "In Progress");
        tasks.AddTask(3, "Testing", "Pending");

        Console.WriteLine("All Tasks:");
        tasks.TraverseTasks();

        Console.WriteLine("\nSearch Task ID 2:");
        tasks.SearchTask(2);

        tasks.DeleteTask(2);

        Console.WriteLine("\nAfter Deletion:");
        tasks.TraverseTasks();
    }
}
