using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic ArrayList with no size limit
            List<int> numberList = new List<int>();
            numberList.Add(32);
            numberList.Add(21);
            numberList.Add(45);
            numberList.Add(11);
            numberList.Add(89);

            for (int i = 0; i < numberList.Count ; i++)
                Console.WriteLine($"Item: {i} => {numberList[i]}");

            Console.WriteLine("---------------------------");

            // List of string
            List<string> authors = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");

            for (int i = authors.Count - 1; i>=0; i--)
                Console.WriteLine($"Item: {i} => {authors[i]}");
        }
    }
}
