using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Carro
    {
        private string _cor;
        public string Cor
        {
            get => _cor;
            set => _cor = value;
        }
        private string _marca;
        public string Marca
        {
           get { return _marca; }
           set { _marca = value; }
        }

        public string AnoFabricacao
        { get; set; }
        private string TipoCombustivel
        { get; set; }

        public Carro ()
        {
            _cor = "branco";
        }

        public Carro(string cor, string marca)
        {
            _cor = cor;
            _marca = marca;
        }

        public void Acelerar()
        {

        }

        public void Frear()
        {

        }

        public void VirarDireita()
        {

        }
        private void VirarEsquerda()
        {

        }


    }
}
