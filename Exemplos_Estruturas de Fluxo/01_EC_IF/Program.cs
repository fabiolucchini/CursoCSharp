using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EC_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorPoupancaTexto;
            float valorPoupanca;
            Console.Write("Digite o valor que você possui na conta poupança: ");
            valorPoupancaTexto = Console.ReadLine();
            valorPoupanca = float.Parse(valorPoupancaTexto);

            if ( valorPoupanca > 100000 )
            {
                Console.Write("Você cliente VIP possui uma taxa de juros diferenciada.");
            } else if ( valorPoupanca > 50000)
            {
                Console.Write("Você é um cliente especial com taxa de juros de 1.2% ao mês.");
            }
            else
            {
                Console.Write("Você é um cliente especial. Mas sua taxa de juros é normal(0,5% ao mês).");
            }

            Console.ReadKey();
        }
    }
}
