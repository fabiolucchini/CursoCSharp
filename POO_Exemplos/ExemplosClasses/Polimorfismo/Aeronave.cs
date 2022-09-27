using System;

namespace CSharp_Polimorfismo1
{
    public class Aeronave : Veiculo
    {
        public Aeronave(string tipoVeiculo)
            : base(tipoVeiculo)
        { }

        public override void Mover()
        {
            Console.WriteLine("Decolando a aeronave");
        }
        public override void Parar()
        {
            Console.WriteLine("Estou aterrisando a aeronave.");
        }
    }
}
