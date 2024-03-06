namespace TodoProject
{
    public class Todo
    {
        List<string> todos;

        public Todo()
        {
            this.todos = new List<string>();
        }


        void SeeTodos()
        {
            if (this.todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet");
                return;
            }

            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i}. {todos[i]}");
            }
        }

        void RemoveTodo()
        {

            if (this.todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Select the index of the TODO you want to remove:");
                    for (int i = 0; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i}. {todos[i]}");
                    }
                    int userChoice = int.Parse(Console.ReadLine());

                    // Check if user choice is valid or not
                    if (userChoice < 0 || userChoice > todos.Count)
                    {
                        Console.WriteLine("The given index is not valid.");
                        continue;
                    }
                    else
                    {
                        string removedTodo = this.todos[userChoice];
                        this.todos.RemoveAt(userChoice);
                        Console.WriteLine($"TODO removed: [{removedTodo}] ");
                        break;
                    }
                }
            }


        }

        void AddTodo()
        {

            while (true)
            {
                Console.WriteLine("Enter the TODO description: ");
                string inputTodo = Console.ReadLine();

                if (string.IsNullOrEmpty(inputTodo))
                {
                    // Checking user input is empty or not
                    Console.WriteLine("The description cannot be empty.");
                }
                else if (this.todos.IndexOf(inputTodo) != -1)
                {
                    // Duplicate todo
                    Console.WriteLine("The description must be unique.");
                }
                else
                {
                    // todo is unique and not empty
                    // add the todo
                    this.todos.Add(inputTodo);
                    Console.WriteLine($"TODO successfully added: [{inputTodo}]");
                    break;
                }
            }

        }

        public void Run()
        {
            while (true)
            {
                switch (this.Menu())
                {
                    case 's':
                        SeeTodos();
                        break;
                    case 'a':
                        AddTodo();
                        break;
                    case 'r':
                        RemoveTodo();
                        break;
                    case 'e':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice! try again.");
                        break;
                }
            }
        }

        char Menu()
        {
            bool isSuccessfullyParsed = true;
            char userChoice;
            while (true)
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[S]ee all TODOs.");
                Console.WriteLine("[A]dd a TODO.");
                Console.WriteLine("[R]emove a TODO.");
                Console.WriteLine("[E]xit");
                isSuccessfullyParsed = char.TryParse(Console.ReadLine().ToLower(), out userChoice);

                if (isSuccessfullyParsed) break;
                else
                {
                    Console.WriteLine("Incorrect input!");
                    continue;
                }
            }
            return userChoice;
        }
    }
}
