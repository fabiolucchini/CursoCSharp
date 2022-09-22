using System;
using System.Collections;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a stack
            // Using Stack class
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("AAA");
            my_stack.Push("BBB");
            my_stack.Push('C');
            my_stack.Push(null);
            my_stack.Push(1234);
            my_stack.Push(490.98);

            // Accessing the elements
            // of my_stack Stack
            // Using foreach loop
            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
