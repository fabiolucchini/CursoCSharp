namespace CShp_HerancaComposicao
{
    public class Casa
    {
        public Banheiro banheiro;
        public Cozinha cozinha;
        public Quarto quarto;

        public string Proprietario{ get; set; }
        public Casa(Quarto _quarto, Cozinha _cozinha, Banheiro _banheiro)
        {
            quarto = _quarto;
            cozinha = _cozinha;
            banheiro = _banheiro;
        }

        public override string ToString()
        {
            return $"{quarto.Descricao()} -  {cozinha.Descricao()} " +
                $" - {banheiro.Descricao()}";
        }
    }
}
