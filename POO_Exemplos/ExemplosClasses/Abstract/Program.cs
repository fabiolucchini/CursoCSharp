using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abstract;

namespace Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {

            Quadrado q = new Quadrado();
            Console.WriteLine(q.Descricao());
            Console.WriteLine("Informe o valor do lado do quadrado em metros.");
            q.Lado = Convert.ToInt32(Console.ReadLine());
            q.CalcularArea();
            q.CalcularPerimetro();
            Console.WriteLine("A área do quadrado é : " + q.Area + " m2 ");
            Console.WriteLine("O perímetro do quadrado é : " + q.Perimetro + " m ");
            Console.ReadKey();
        }
    }
}
