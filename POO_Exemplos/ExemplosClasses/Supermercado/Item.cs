using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class Item
    {
        float _preco;
        float _total;
        List<Produto> _produtos;

        public Item()
        {
            _produtos = new List<Produto>();
            _produtos.Add(new Produto { Estoque = 10,Preco=2.00F,Nome="Bolacha" });
            _produtos.Add(new Produto { Estoque = 23, Preco = 20.00F, Nome = "Arroz 5Kg" });
            _produtos.Add(new Produto { Estoque = 100, Preco = 7.60F, Nome = "Feijao 1Kg" });
            _produtos.Add(new Produto { Estoque = 60, Preco = 5.50F, Nome = "Açucar 1Kg" });
            _produtos.Add(new Produto { Estoque = 70, Preco = 11.60F, Nome = "Farinha de Trigo 1Kg" });
        }

        public bool MontarPreco(string nomeProduto, float quantidade)
        {
            Produto produto = _produtos.Find(x => x.Nome.Contains(nomeProduto));
            if (produto == null)
                return false;
            _preco = produto.Preco;
            _total = _preco * quantidade;
            return true;

        }
        public float GetTotalProduto()
        {
            return _total;
        }
    }
}
