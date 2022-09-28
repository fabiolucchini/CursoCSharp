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
    class Pedido:IPedido
    {
        Cliente _cliente;
        List<Item> _Itens = new List<Item>();
        List<Produto> _produtos = null;
        FormaPagamento _formaPagamento;
        ePagamento _pagamento;
        public ePagamento Pagamento { get => _pagamento; set => _pagamento = value; }

        public Pedido(string nomeCliente, ref List<Produto> produtos)
        {
            _cliente = new Cliente(nomeCliente);
            _produtos = produtos;
            _pagamento = ePagamento.Cartao;
            
        }

       
        public bool AdicionarItem ( string nomeProduto, float quantidade)
        {
            Item itemProduto = new Item(ref _produtos);
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
        public void ListarTodosProdutos()
        {

        }
    }
}
