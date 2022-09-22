using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating HashSet    // Using HashSet class
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet    // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            // Accessing elements of HashSet    // Using foreach loop
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            // Creating another HashSet    // using collection initializer    // to initialize HashSet
            HashSet<int> myhash2 = new HashSet<int>() { 10, 100, 1000, 10000, 100000 };
            // Display elements of myhash2
            Console.WriteLine("Elements of myhash2:");
            foreach (var value in myhash2)
            {
                Console.WriteLine(value);
            }

        }
    }
}
