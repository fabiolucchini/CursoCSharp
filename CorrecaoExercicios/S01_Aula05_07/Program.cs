using System;

namespace S01_Aula05_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                try
                {
                    Console.Write("Digite um numero:");
                    numero = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Terminei o loop");
            Console.ReadKey();

        }
    }
}
