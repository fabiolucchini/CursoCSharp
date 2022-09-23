using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Mudar_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Olá amiguinhos! Feliz ano novo!";

            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());

            Console.ReadKey();
        }
    }
}
