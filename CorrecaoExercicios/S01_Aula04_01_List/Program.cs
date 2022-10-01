using System;
using System.Collections.Generic;

namespace S01_Aula04_01_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeLugares = 2;
            int contador = 0;
            List<Resposta> listRespostas = new List<Resposta>();
            int quantidadeRespostasOtimo = 0;
            float mediaIdadeRuim = 0;
            float porcentagemPessimos = 0;
            int quantidadePessimos = 0;
            int quantidadeRuim = 0;
            int maiorIdadePessimo = 0;
            int idade;
            string resposta;
            //----------------------------------------
            // Entrada dos dados
            //----------------------------------------
            while (contador < quantidadeLugares)
            {
                Resposta respostaCliente = new Resposta();
                Console.Write("Qual a dua Idade:");
                respostaCliente.Idade = int.Parse(Console.ReadLine());
                Console.Write("Sua opnião (O)ótimo, (B)bom, (R)regular ou (P)péssimo:");
                respostaCliente.RespostaCinema = Console.ReadLine();
                contador++;
                listRespostas.Add(respostaCliente);
            }
            //----------------------------------------
            // Processamento das informações
            //----------------------------------------
            foreach (var item in listRespostas)
            {
                idade = item.Idade;
                resposta = item.RespostaCinema;
                if (resposta == "P" && idade > maiorIdadePessimo)
                    maiorIdadePessimo = idade;
                if (resposta == "P")
                    quantidadePessimos++;
                if (resposta == "R")
                {
                    mediaIdadeRuim += idade;
                    quantidadeRuim++;
                }
                if (resposta == "O")
                    quantidadeRespostasOtimo++;
            }
            mediaIdadeRuim /= (float)quantidadeRuim;
            porcentagemPessimos = (((float)quantidadePessimos / (float)quantidadeLugares) * 100);
            //----------------------------------------
            // Exibição dos dados
            //----------------------------------------
            Console.Clear();
            Console.WriteLine("Quantidade de Respostas Ótimas..: " + quantidadeRespostasOtimo.ToString());
            Console.WriteLine("Media de Idade de resposta Ruim.: " + mediaIdadeRuim.ToString("F1"));
            Console.WriteLine("Porcentagem de Respostas Péssimo: " + porcentagemPessimos.ToString("F1") + "%");
            Console.WriteLine("Maior idade que escolheu Péssimo: " + maiorIdadePessimo);

        }
    }
}
