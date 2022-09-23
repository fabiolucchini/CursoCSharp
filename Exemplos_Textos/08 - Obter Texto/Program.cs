using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Obter_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Olá a todos! Desejo feliz ano novo!";

            String frase = texto.Substring(13);
            String palavra = texto.Substring(13, 6);

            Console.WriteLine("Frase: " + frase);
            Console.WriteLine("Palavra: " + palavra);

            Console.ReadKey();
        }
    }
}
