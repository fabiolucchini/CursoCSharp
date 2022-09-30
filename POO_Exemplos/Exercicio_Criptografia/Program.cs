using System;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            Criptografia cripto = new Criptografia(CryptProvider.DES);
            cripto.Key = "Curs0C$harp@2022!";
            string texto = cripto.Encrypt("Teste da Aula C#");
            Console.WriteLine("Texto:" + texto);
            texto = cripto.Decrypt(texto);
            Console.WriteLine("Texto:" + texto);
        }
    }
}
