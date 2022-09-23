using System;
using System.IO;

namespace GravarDados_EmArquivo
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] lines = { "Linha 1", "LInha 2", "Linha 3" };         
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Gravar as linhas dentro do arquivo
            using (System.IO.StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
            // Acrescentar linhas no arquivo
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                outputFile.WriteLine("Fourth Line");
            }
        }
    }
}
