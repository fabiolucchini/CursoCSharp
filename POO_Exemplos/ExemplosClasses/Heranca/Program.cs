using System;

namespace CShp_HerancaComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //HerancaCarro();
            ComposicaoCasa();

            Console.ReadLine();
        }

        private static void ComposicaoCasa()
        {
            var meuQuarto = new Quarto();
            var minhaCozinha = new Cozinha();
            var meuBanheiro = new Banheiro();
            Casa minhaCasa = new Casa(meuQuarto, minhaCozinha, meuBanheiro);
            minhaCasa.Proprietario = "Casa do Chico Bento :";
            Console.WriteLine(minhaCasa.Proprietario);
            Console.WriteLine(minhaCasa.ToString());
        }

        private static void HerancaCarro()
        {
            Carro fusca = new Carro();
            fusca.Cor = "Preto";
            fusca.Modelo = "Fusca 1500";
            fusca.NumeroChassis = "LKJDYDO98867o90";
            fusca.Proprietario = "Chico Bento";
            Console.WriteLine(fusca.ToString());
            Console.WriteLine(fusca.NumeroChassis);
            Console.WriteLine(fusca.Proprietario);
            fusca.Mover();
        }
    }
}
