using System;

namespace CShp_HerancaComposicao
{
    class Veiculo
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public virtual void Mover()
        {
            Console.WriteLine("O veículo esta se movendo");
        }
        public override string ToString()
        {
            return ($"{Modelo} - {Cor}");
        }
    }
}
