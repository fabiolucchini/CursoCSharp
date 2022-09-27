using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Forma
    {
        private double _area;
        private string _cor;
        private double _perimetro;

        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                _cor = value;
            }
        }

        public double Area
        {
            get
            { return _area; }
            set
            { _area = value; }

        }

        public double Perimetro
        {
            get
            { return _perimetro; }
            set
            { _perimetro = value; }
        }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public string Descricao()
        {
            return "Sou a classe abstrata Forma.";
        }
    }
}
