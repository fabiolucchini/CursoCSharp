using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class Produto
    {
        private float _preco;
        public float Preco { get => _preco; set => _preco = value; }
        private float _estoque;
        public float Estoque { get => _estoque; set => _estoque = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal List<Produto> Produtos { get => _produtos; set => _produtos = value; }

        private string _nome;

        static List<Produto> _produtos;

        public bool DiminuirEstoque( float quantidade)
        {            
            _estoque -= quantidade;
            return true;
        }

        public List<Produto> CarregarBancoDeDados()
        {
            Produtos = new List<Produto>();
            Produtos.Add(new Produto { Estoque = 10, Preco = 2.00F, Nome = "Bolacha" });
            Produtos.Add(new Produto { Estoque = 23, Preco = 25.00F, Nome = "Arroz 5Kg" });
            Produtos.Add(new Produto { Estoque = 100, Preco = 7.60F, Nome = "Feijao 1Kg" });
            Produtos.Add(new Produto { Estoque = 60, Preco = 5.50F, Nome = "Açucar 1Kg" });
            Produtos.Add(new Produto { Estoque = 70, Preco = 11.60F, Nome = "Farinha de Trigo 1Kg" });
            return Produtos;
        }

        public void ImprimirProdutos()
        {
            int tamanho = 20;
            Console.WriteLine($"Nome\t\t\t\tPreço\t\tEstoque");
            Console.WriteLine("===========================================================");
            foreach ( Produto p in _produtos)
            {
                string nome_local = p.Nome.Length < tamanho ? p.Nome : p.Nome.Substring(0,tamanho - 1);
                String s = new String('.', (tamanho - nome_local.Length)-1);                
                Console.WriteLine($"{nome_local+s}\t\t{p.Preco}\t\t{p.Estoque}");
            }
        }




    }
}
