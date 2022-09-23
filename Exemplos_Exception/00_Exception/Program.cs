using System;

namespace _00_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int dividendo = int.Parse(Console.ReadLine());
                int divisor = int.Parse(Console.ReadLine());
                int resultado = dividendo / divisor;
                Console.WriteLine(resultado);
            }
            catch (FormatException erro)
            {
                Console.WriteLine("O valor digitado não é um número");
                Console.WriteLine(erro.Message);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine("Divisão por zero");
                Console.WriteLine(erro.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro:\n" + e.Message);
            }
            finally
            {
                Console.WriteLine( "Fim" );
            }

        }
    }
}
