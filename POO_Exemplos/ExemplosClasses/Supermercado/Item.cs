using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class Item
    {
        float _preco=0;
        float _total=0;
        List<Produto> _produtos = null;


        public Item(ref List<Produto> produtos)
        {
            _produtos = produtos;
        }
        public bool MontarPreco(string nomeProduto, float quantidade)
        {
            Produto produto = _produtos.Find(y => y.Nome.Contains(nomeProduto));
            //Produto produto = Find(nomeProduto);
            if (produto == null)
                return false;
            _preco = produto.Preco;
            _total = _preco * quantidade;
            produto.DiminuirEstoque(quantidade);
            Console.WriteLine($"# {produto.Nome} => {produto.Preco} * {quantidade} = {_total}");
            return true;

        }

        private Produto Find ( string nomeProduto)
        {
            Produto produto = null;
            foreach (Produto p in _produtos)
            {
                if (p.Nome.Contains(nomeProduto))
                {
                    produto = p;
                    break;
                }
            }
            return produto;            
        }

        public float GetTotalProduto()
        {
            return _total;
        }
    }
}
