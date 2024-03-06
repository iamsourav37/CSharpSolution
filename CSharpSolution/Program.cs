using System.Diagnostics;
using TodoProject;

namespace CSharpSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Todo todo = new();
            var choice = todo.Menu();
            Console.WriteLine(choice);
        }
    }
}
