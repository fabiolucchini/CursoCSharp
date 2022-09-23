using System;
using System.IO;

namespace GravarDados_File
{
    class Program
    {
        static void Main(string[] args)
        {            
            string text = "Linha 1" + Environment.NewLine;         
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Cria um novo arquivo e grava os dados
            File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), text);

            //Cria uma nova string para ser gravada em arquivo
            string[] lines = { "Nova Linha 2", "Nova Linha 3" };

            // Acrescente as linhas no mesmo arquivo
            File.AppendAllLines(Path.Combine(docPath, "WriteFile.txt"), lines);
        }
    }
}
