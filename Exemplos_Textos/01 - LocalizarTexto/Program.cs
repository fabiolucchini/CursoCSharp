using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___LocalizarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Olá amigos, estou muito feliz de esta aqui com voces. Desejo a todos um feliz ano novo.";
            String palavra = "feliz";

            Console.WriteLine("Tamanho do texto: " + texto.Length);
            Console.WriteLine("Localizar: " + texto.IndexOf(palavra));
            Console.WriteLine("Localizar último: " + texto.LastIndexOf(palavra));
            
            Console.ReadKey();

        }
    }
}
