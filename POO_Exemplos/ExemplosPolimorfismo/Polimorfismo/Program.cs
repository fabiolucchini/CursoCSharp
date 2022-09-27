using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Teste(); // saída --> "A::Teste()"

            B b = new B();
            b.Teste(); // saída --> "A::Teste()"

            C c = new C();
            c.Teste(); // saída --> "A::Teste()"

            Console.ReadKey();
        }
    }

    public class A
    {
        public void Teste()
        { 
            Console.WriteLine("A::Teste()"); 
        }
    }

    public class B : A { }

    public class C : B { }
}
