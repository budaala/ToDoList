namespace ToDoListApp {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To Do List App!");
            List<string> taskList = new();
            var option = "";

            while (option != "e")
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1) to add a task to the list");
                Console.WriteLine("(2) to remove a task from the list");
                Console.WriteLine("(3) to view the list");
                Console.WriteLine("(e) to exit the program");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please enter the name of the task to add to the list: ");
                        var task = Console.ReadLine();
                        if (string.IsNullOrEmpty(task))
                        {
                            Console.WriteLine("The task shouldn't be empty. Try adding it again.");
                            break;
                        } 
                        taskList.Add(task);
                        Console.WriteLine("The task has been added to the list successfully!");
                        break;
                    case "2":
                        ListItems(taskList);
                        Console.WriteLine("Please enter the number of the task that you want to remove: ");
                        try
                        {
                            int taskNumber = Convert.ToInt32(Console.ReadLine());
                            taskList.RemoveAt(taskNumber-1);
                            Console.WriteLine("The task has been removed from the list successfully!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        break;
                    case "3":
                        ListItems(taskList);
                        break;
                    case "e":
                        Console.WriteLine("Exiting program...");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again by typing 1, 2, 3 or e.");
                        break;
                }
            }
        }

        public static void ListItems(List<string> taskList)
        {
            if (taskList.Count < 1)
            {
                Console.WriteLine("The task list is empty. First add a task.");
                return;
            }
            Console.WriteLine("Current tasks in the list: ");
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + taskList[i]);
            }
        }
    }
}
