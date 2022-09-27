using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Cor = "azul";
            carro.Marca = "Honda";
            Console.WriteLine(carro.Cor+" " +carro.Marca);
            carro.VirarDireita();
        }
    }
}
