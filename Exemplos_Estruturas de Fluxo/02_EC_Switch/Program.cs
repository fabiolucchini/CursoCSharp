using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EC_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu estado civil? (Informe: S - Solteiro, C - Casado, V - Viuvo, D - Divorciado)");
            string valor = Console.ReadLine();
            switch (valor)
            {
                case "S":
                    Console.Write("Você está solteiro, sugestão: Encontre alguem na rede social.");
                    break;
                case "C":
                    Console.Write("Você é casado, sugestão: Prepare um noite especial.");
                    break;
                case "V":
                    Console.Write("Você é viuvo, sugestão: Tente outra vez.");
                    break;
                case "D":
                    Console.Write("Você é divorciado, sugestão: Tente reatar.");
                    break;
                default:
                    Console.Write("Comando não reconhecido!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
