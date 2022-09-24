using System;
using System.Collections.Generic;

namespace _3H
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> listaRespostas = new List<char>();

            char resposta=' ';
            while ( resposta != '-')
            {
                Console.Clear();
                Console.WriteLine(" O  Ótimo");
                Console.WriteLine(" B  Bom");
                Console.WriteLine(" R  Regular");
                Console.WriteLine(" U  Ruim");
                Console.WriteLine(" -  Sair");
                Console.WriteLine();
                Console.Write(" Opção: ");
                resposta = char.Parse(Console.ReadLine().ToUpper());
                if (resposta == 'O' || resposta == 'B' || resposta == 'R' || resposta == 'U')
                    listaRespostas.Add(resposta);
            }

            int bom = 0, otimo = 0, regular = 0, ruim = 0, total = 0;
            foreach ( char respostaAtual in listaRespostas)
            {
                total++;
                switch (respostaAtual)
                {
                    case 'B':
                        bom++;
                        break;
                    case 'O':
                        otimo++;
                        break;
                    case 'R':
                        regular++;
                        break;
                    case 'U':
                        ruim++;
                        break;
                }
            }
            Console.WriteLine($"Total de respostas = {total}");
            Console.WriteLine($"==================================");
            Console.WriteLine($"Ótimo teve....{otimo}... respostas");
            Console.WriteLine($"Bom teve......{bom}..... respostas");
            Console.WriteLine($"Regular teve..{regular}. respostas");
            Console.WriteLine($"Ruim teve.....{ruim}..... respostas");
            Console.WriteLine($"==================================");
            Console.WriteLine($"Ótimo teve....{(((float)otimo/(float)total)*100).ToString("F1")}%... respostas");
            Console.WriteLine($"Bom teve......{(((float)bom / (float)total)*100).ToString("F1")}%..... respostas");
            Console.WriteLine($"Regular teve..{(((float)regular / (float)total)*100).ToString("F1")}%. respostas");
            Console.WriteLine($"Ruim teve.....{(((float)ruim / (float)total)*100).ToString("F1")}%..... respostas");
            Console.WriteLine($"==================================");
            int soma_ob = otimo + bom;
            int soma_ru = regular + ruim;
            if (soma_ob > soma_ru)
                Console.WriteLine($"Soma de Otimos e bons ({soma_ob}) é maior que a soma dos regulares e ruins({soma_ru})");
        }
    }
}
