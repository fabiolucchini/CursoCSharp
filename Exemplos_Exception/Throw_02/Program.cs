using System;

namespace Throw_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o número de um mês: ");
                int mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Mês:" + nomeMes(mes));
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: "+e.Message);                
            }
            finally
            {
                Console.WriteLine("Fim");
            }
            
        }
        static string nomeMes(int mes)
        {
            switch (mes)
            {
                case 1: return "Janeiro";
                case 2: return "Fevereiro";
                case 3: return "Março";
                case 4: return "Abril";
                case 5: return "Maio";
                case 6: return "Junho";
                case 7: return "Julho";
                case 8: return "Agosto";
                case 9: return "Setembro";
                case 10: return "Outubro";
                case 11: return "Novembro";
                case 12: return "Dezembro";
                default:
                    throw new ArgumentOutOfRangeException("Mês inválido");
            }
        }
    }
}
