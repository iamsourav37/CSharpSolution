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
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i}. {todos[i]}");
            }
        }

        void RemoveTodo()
        {
            Console.WriteLine("Select the index of the TODO you want to remove:");
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i}. {todos[i]}");
            }
            int userChoice = int.Parse(Console.ReadLine());
            string removedTodo = this.todos[userChoice];
            this.todos.RemoveAt(userChoice);
            Console.WriteLine($"TODO removed: [{removedTodo}] ");
        }

        void AddTodo()
        {
            Console.WriteLine("Enter the TODO description: ");
            string inputTodo = Console.ReadLine();
            this.todos.Add(inputTodo);
            Console.WriteLine($"TODO successfully added: [{inputTodo}]");
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

            Console.WriteLine("Hello!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[S]ee all TODOs.");
            Console.WriteLine("[A]dd a TODO.");
            Console.WriteLine("[R]emove a TODO.");
            Console.WriteLine("[E]xit");

            return Convert.ToChar(Console.ReadLine().ToLower());
        }
    }
}
