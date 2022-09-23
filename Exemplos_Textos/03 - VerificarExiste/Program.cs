using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___VerificarExiste
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Olá amigos José Costa Ribeiro Martins!";

            Console.WriteLine("Verificar existência no inicio: " + texto.StartsWith("Olá"));

            Console.WriteLine("Verificar existência no final: " + texto.EndsWith("!"));

            Console.WriteLine("Verificar exstência: " + texto.Contains("Costa") );

            Console.ReadKey();
        }
    }
}
