using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Formatar_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Elias Costa";
            string texto = "Bem vindo " + nome + "! Feliz natal!";

            string textoFormatado = String.Format("Bem vindo {0}! Feliz Natal!{0} {1}", nome, "Feliz");

            Console.WriteLine(texto);
            Console.WriteLine(textoFormatado);
            Console.ReadKey();
        }
    }
}
