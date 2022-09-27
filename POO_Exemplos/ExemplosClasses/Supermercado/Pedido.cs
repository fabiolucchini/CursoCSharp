using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    public enum ePagamento : int
    {
        Cartao = 0,
        Dinheiro = 1,
        Cheque = 2,
        Pix = 3
    }
    class Pedido
    {
        Cliente _cliente;
        List<Item> _Itens = new List<Item>();
        FormaPagamento _formaPagamento;
        ePagamento _pagamento;

        public Pedido(string nomeCliente)
        {
            _cliente = new Cliente(nomeCliente);
            _pagamento = ePagamento.Cartao;
            
        }

        public ePagamento Pagamento { get => _pagamento; set => _pagamento = value; }

        public bool AdicionarItem ( string nomeProduto, float quantidade)
        {
            Item itemProduto = new Item();
            if (!itemProduto.MontarPreco(nomeProduto, quantidade))
                return false;
            _Itens.Add(itemProduto);
            return true;
        }

        public float Total()
        {
            float total = 0;
            foreach( Item item in _Itens)
            {
                total += item.GetTotalProduto();
            }
            return total;
        }
    }
}
