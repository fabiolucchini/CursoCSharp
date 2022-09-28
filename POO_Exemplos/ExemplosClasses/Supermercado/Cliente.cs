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
        internal Situacao_Usuario Situacao { get => _situacao; set => _situacao = value; }

        public enum Situacao_Usuario : int
        {
            Ativo = 1,
            Inativo = 0,
            Cancelado = -1
        }
        Situacao_Usuario _situacao;


        public Cliente(string nome, Situacao_Usuario situacao)
        {
            Nome = nome;
            Situacao = situacao;

        }

        
    }
}
