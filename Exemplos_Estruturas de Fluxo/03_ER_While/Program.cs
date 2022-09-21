using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ER_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Valor da variável: " + i);
                i = i + 1;
            }

            int x = 0;
            bool repetir = true;
            while (repetir)
            {
                Console.WriteLine("Valor da variável X: " + x);
                if (x > 20)
                {
                    Console.Write("Saindo do programa");
                    repetir = false;
                }
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
