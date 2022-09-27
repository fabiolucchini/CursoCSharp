using System;

namespace Interface
{
    class Program
    {       
        interface inter1
        {
            void display();
        }
        class testClass : inter1
        {
            public void display()
            {
                Console.WriteLine("Classe com a Interface");
            }
            // Main Method
            public static void Main(String[] args)
            {
                testClass t = new testClass();
                t.display();
            }
        }
    }
}
