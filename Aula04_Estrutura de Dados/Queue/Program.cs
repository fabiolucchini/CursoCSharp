using System;
using System.Collections.Generic;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a Queue 
            Queue<string> myQueue = new Queue<string>();
            // Inserting the elements into the Queue
            myQueue.Enqueue("one");
            // Displaying the count of elements    // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("two");
            // Displaying the count of elements    // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("three");
            // Displaying the count of elements    // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("four");
            // Displaying the count of elements    // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("five");
            // Displaying the count of elements    // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue("six");
            // Displaying the count of elements    // contained in the Queue
            Console.Write("Total number of elements in the Queue are : ");
            Console.WriteLine(myQueue.Count);
        }
    }
}
