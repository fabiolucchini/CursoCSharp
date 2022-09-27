using System;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido compra = new Pedido("Fabio");
            compra.AdicionarItem("Bolacha", 2);
            compra.AdicionarItem("Arroz 5Kg", 3);
            compra.AdicionarItem("Açucar 1Kg", 2);
            Console.WriteLine($"Valor total da compra: {compra.Total().ToString("F2")}");
        }
    }
}
