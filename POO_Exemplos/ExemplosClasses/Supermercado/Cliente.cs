using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado
{
    class Cliente
    {
        private string _nome;
        public string Nome { get => _nome; set => _nome = value; }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        
    }
}
