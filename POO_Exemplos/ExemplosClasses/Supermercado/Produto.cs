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
        private int _estoque;
        public int Estoque { get => _estoque; set => _estoque = value; }
        public string Nome { get => _nome; set => _nome = value; }

        private string _nome;
        
    }
}
