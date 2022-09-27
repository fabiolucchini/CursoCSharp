using System;

namespace PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carro city = new Carro("azul", "ford", "aaa-1234", "v8");
            Carro city = new Carro();
            city.Cor = "Preto";
            city.Marca = "City";
            city.Placa = "ABC-1234";
            city.SetFabricante("Honda");
            
            Console.WriteLine( city.InformarResumo() );

            city.Acelerar(20);

            
        }
    }
}
