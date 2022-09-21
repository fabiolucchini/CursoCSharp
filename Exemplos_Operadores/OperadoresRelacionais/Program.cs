using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  !(10 == 10)    );

            Console.WriteLine(10 == 10);
            Console.WriteLine(11 == 10);

            if (10 == 10){
                Console.WriteLine("10 é igual a 10"); 
            }

            Console.WriteLine(10 > 9);
            Console.WriteLine(10 < 9);

            Console.WriteLine(10 >= 9);
            Console.WriteLine(10 <= 9);

            Console.WriteLine(10 != 10);

            

            Console.ReadKey();
        }
    }
}
