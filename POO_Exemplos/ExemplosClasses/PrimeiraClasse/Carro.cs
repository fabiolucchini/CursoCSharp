using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    class Carro
    {
        //-----------------------------------
        // Exemplo 01
        //-----------------------------------
        private string _cor;
        public string Cor
        {
            get => _cor;
            set => _cor = value.ToUpper();
        }

        //-----------------------------------
        // Exemplo 02
        //-----------------------------------
        public string Marca { get; set; }

        //-----------------------------------
        // Exemplo 03
        //-----------------------------------
        private string _fabricante;
        public void SetFabricante ( string fabricante)
        { _fabricante = fabricante; }
        public string GetFabricante()
        { return _fabricante; }

        private string _motor;
        private string _placa;
        public string Placa
        {
            get => _placa;
            set => _placa = value.ToUpper();
        }

        //-----------------------------------------
        // Construtores
        //-----------------------------------------
        public Carro()
        {
            _cor = "Não definda";
            Marca = "Não definida";
            _placa = "";
            _motor = "XXX";
        }
        public Carro(string cor,string marca, string placa, string motor)
        {
            _cor = cor;
            Marca = marca.ToUpper();
            _placa = placa.ToUpper();
            _motor = motor.ToUpper();
        }

        //-----------------------------------------
        // Métodos
        //-----------------------------------------
        public void Acelerar ( int velocidade)
        {

        }

        public string InformarResumo ()
        {
            string retorno = "Placa não definida";
            if ( _placa.Length==8 )
                retorno = $"Carro {Marca}, Fabricante:{_fabricante}, Cor:{_cor}, Placa:{_placa}, Motor:{_motor}";

            return retorno;
        }

    }
}
