using System;
using System.Collections.Generic;

namespace Hashset_X_List
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("\n********************************");
            Console.Write("\n**  HashSet usage example    ** \n");
            Console.Write("********************************\n\n");

            //Define a numbers List
            List<int> numbers = new List<int>() { 10, 25, 45, 78, 12, 10, 78, 45, 100, 100, 25 };
            Console.WriteLine("Get Count(List): " + numbers.Count);
            Console.WriteLine("The Data int List");
            //Output in List
            foreach (var n in numbers)
            {
                Console.Write(n + "\t");
            }
            Console.Write("\n********************************\n\n");


            //Define a numbers HashSet
            HashSet<int> hSet = new HashSet<int>(numbers);
            Console.WriteLine("Get Count(HashSet): " + hSet.Count);
            //Output in Hashset
            Console.WriteLine("The Data int HashSet");
            foreach (var n in hSet)
            {
                Console.Write(n + "\t");
            }            
            Console.ReadLine();
        }
    }
}
