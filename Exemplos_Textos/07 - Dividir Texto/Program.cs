using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Dividir_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomes = "João, Maria, José, Jesus, Filipe, Tiago e Paulo.";
            string[] separador = { ", ", " e " };
            string[] nomesArray = nomes.Split(separador, StringSplitOptions.None);  

            foreach(string nome in nomesArray)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
