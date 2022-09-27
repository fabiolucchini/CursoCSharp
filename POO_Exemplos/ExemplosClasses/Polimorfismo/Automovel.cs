using System;

namespace CSharp_Polimorfismo1
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoVeiculo)
            : base(tipoVeiculo)
        { }

        public override void Mover()
        {
 	        Console.WriteLine("Acelerando o veículo");
        }
        public override void Parar()
        {
            Console.WriteLine("Estou brecando o veículo.");
        }
    }
}
