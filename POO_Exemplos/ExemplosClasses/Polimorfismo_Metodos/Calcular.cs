
namespace Polimorfismo_SobrecargaMetodos
{
    class Calcular
    {
        public int Soma(int num1, int num2)
        {
            return (num1 + num2);
        }
        
        public int Soma(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
    }
}
