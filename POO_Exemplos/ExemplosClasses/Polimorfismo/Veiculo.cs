namespace CSharp_Polimorfismo1
{
    public class Veiculo
    {
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Veiculo(string tipoVeiculo)
        {
            this.tipo = tipoVeiculo;
        }

        public virtual void Mover()
        { }

        public virtual void Parar()
        { }
    }
}
