using System;

namespace Throw
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Minutos:");
                int minutos = int.Parse(Console.ReadLine());
                if (minutos < 1 || minutos >= 60)
                {
                    throw new Exception("horário inválido");
                }
                Console.WriteLine(minutos);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
