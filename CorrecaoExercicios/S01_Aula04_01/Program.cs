using System;
using System.Collections;

namespace S01_Aula04_01
{
    class Program
    {
        static void Main(string[] args)
        {            
            int quantidadeLugares = 10;
            int contador = 0;
            string[,] cinema = new string[quantidadeLugares, 2];
            int quantidadeRespostasOtimo = 0;
            float mediaIdadeRuim=0;
            float porcentagemPessimos=0;
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
                Console.Write("Qual a dua Idade:");
                cinema[contador,0] = Console.ReadLine();
                Console.Write("Sua opnião (O)ótimo, (B)bom, (R)regular ou (P)péssimo:");
                cinema[contador,1] = Console.ReadLine();
                contador++;
            }
            //cinema[ contador,0] = "40";
            //cinema[ contador,1] = "O";
            //cinema[ ++contador,0] = "30";
            //cinema[ contador,1] = "O";
            //cinema[ ++contador,0] = "20";
            //cinema[ contador,1] = "R";
            //cinema[ ++contador,0] = "10";
            //cinema[ contador,1] = "R";
            //cinema[ ++contador,0] = "60";
            //cinema[ contador,1] = "P";
            //cinema[ ++contador,0] = "50";
            //cinema[ contador,1] = "P";
            //cinema[ ++contador,0] = "40";
            //cinema[ contador,1] = "B";
            //cinema[ ++contador,0] = "20";
            //cinema[ contador,1] = "B";
            //cinema[ ++contador,0] = "70";
            //cinema[ contador,1] = "R";
            //cinema[ ++contador,0] = "30";
            //cinema[ contador,1] = "R";

            //----------------------------------------
            // Processamento das informações
            //----------------------------------------
            for ( contador=0; contador < quantidadeLugares; contador++)
            {
                idade = int.Parse(cinema[contador,0]);
                resposta = cinema[contador,1];
                if (resposta == "P" && idade> maiorIdadePessimo)
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
            porcentagemPessimos =  (((float)quantidadePessimos / (float)quantidadeLugares)*100);
            //----------------------------------------
            // Exibição dos dados
            //----------------------------------------
            Console.Clear();
            Console.WriteLine("Quantidade de Respostas Ótimas..: " + quantidadeRespostasOtimo.ToString());
            Console.WriteLine("Media de Idade de resposta Ruim.: " + mediaIdadeRuim.ToString("F1"));
            Console.WriteLine("Porcentagem de Respostas Péssimo: " + porcentagemPessimos.ToString("F1")+"%");
            Console.WriteLine("Maior idade que escolheu Péssimo: " + maiorIdadePessimo);

        }
    }
}
