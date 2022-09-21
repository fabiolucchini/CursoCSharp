using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Continue----------------");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("Linhas: " + i);
            }



            Console.WriteLine("--------------Break----------------");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("Linhas: " + i);
            }

            Console.ReadKey();
        }
    }
}
