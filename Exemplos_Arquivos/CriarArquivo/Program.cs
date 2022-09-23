using System;

namespace CriarArquivo
{
    class Program
    {
        static void Main(string[] args)
        {            
            string folderName = @"c:\Temp"; //Nome de um diretório
            // Concatenar o diretório com uma pasta;
            string pathString = System.IO.Path.Combine(folderName, "CSharp");
            System.IO.Directory.CreateDirectory(pathString); // Criar o diretório            
            string fileName = System.IO.Path.GetRandomFileName()+".txt"; // Obtém um nome temporário de um arquivo
            // Concatenar o diretório com um nome de arquivo;
            pathString = System.IO.Path.Combine(pathString, fileName);
            Console.WriteLine("Arquivo: {0}\n", pathString);
            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Arquivo \"{0}\" já existe.", fileName);
                return;
            }
            // Lê dados do arquvivo
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            System.Console.ReadKey();
        }
    }    
}
