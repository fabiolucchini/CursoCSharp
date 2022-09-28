using System;
using System.Collections.Generic;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Produto produto = new Produto();
            produtos = produto.CarregarBancoDeDados();
            produto.ImprimirProdutos();
            Pedido compra = new Pedido("Fabio", ref produtos);
            Console.WriteLine("###########################################");
            Console.WriteLine("########## Lista de Compras ###############");
            Console.WriteLine("###########################################");
            compra.AdicionarItem("Bolacha", 2);            
            compra.AdicionarItem("Arroz 5Kg", 5);
            compra.AdicionarItem("Açucar 1Kg", 10);
            Console.WriteLine("===========================================");
            Console.WriteLine($"== Valor total da compra: {compra.Total().ToString("F2")}");
            Console.WriteLine("===========================================");
            produto.ImprimirProdutos();
        }
    }
}
