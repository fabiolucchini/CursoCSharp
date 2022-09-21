using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo = "M";
            int idade = 18;

            if( sexo == "M" & idade == 18 )
            {
                Console.WriteLine("Deve se alistar");
            }

            
            if (sexo == "M" || (sexo == "F" & idade == 18))
            {

            }

            if( 10 == 10 & 10 > 9)
            {

            }
            if( 10 == 10 | 10 == 9)
            {

            }

            if ( 9 == 10 && 10 > 9)
            {

            }

            if (10 == 10 || 10 > 9)
            {

            }
        }
    }
}
