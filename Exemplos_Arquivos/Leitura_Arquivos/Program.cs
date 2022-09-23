using System;

namespace Leitura_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo 01
            // Lê o arquivo em uma única string
            string fileName = @"C:\Temp\Exemplo01.txt";
            string text = System.IO.File.ReadAllText(fileName);            
            Console.WriteLine("Exemplo 01 = {0}", text);
            // Exemplo 02
            // Lê cada linha do arquivo e devolve com um vetor
            string[] lines = System.IO.File.ReadAllLines(fileName);
            Console.WriteLine("==================================");
            Console.WriteLine("========= EXEMPLO 02 =============");
            Console.WriteLine("==================================");
            Console.WriteLine("Exemplo 02 = ");
            foreach (string line in lines)
            {                
                Console.WriteLine("\t" + line);
            }
            // Exemplo 03
            // Lê uma linha por vez do arquivo
            Console.WriteLine("==================================");
            Console.WriteLine("========= EXEMPLO 03 =============");
            Console.WriteLine("==================================");
            Console.WriteLine("Exemplo 03 = ");
            foreach (string line in System.IO.File.ReadLines(fileName))
            {
                System.Console.WriteLine(line);                
            }
            Console.ReadKey();
        }
    }    
}
