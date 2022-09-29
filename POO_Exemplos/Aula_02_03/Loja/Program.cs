using System;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            gerente.Nome = "Fabio";
            gerente.Senha = "123";
            gerente.Vender();
            gerente.FazerPagamento();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Marcos";
            funcionario.Senha = "153";
            funcionario.Vender();
            
            Cliente cliente = new Cliente();
            cliente.Nome = "Roberto";
            cliente.Senha = "127";            
        }
    }
}
