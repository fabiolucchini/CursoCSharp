namespace CShp_HerancaComposicao
{
    class Carro : Veiculo
    {
        public string NumeroChassis { get; set; }
        public string Proprietario { get; set; }

        public override void Mover()
        {
            System.Console.WriteLine("Acelerando...");
        }
    }
}
