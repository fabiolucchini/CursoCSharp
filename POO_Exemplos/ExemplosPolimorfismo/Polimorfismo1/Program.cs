using System;

namespace Polimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Teste();    // saida --> "A::Teste()"
            b.Teste();    // saida --> "B::Teste()"
            c.Teste();    // saida --> "C::Teste()"

            a = new B();
            a.Teste();    // saida --> "A::Teste()"

            b = new C();
            b.Teste();    // saida --> "B::Teste()"

            Console.ReadKey();
        }
    }

    public class A
    {
        public void Teste() { Console.WriteLine("A::Teste()"); }
    }

    public class B : A
    {
        public void Teste() { Console.WriteLine("B::Teste()"); }
    }

    public class C : B
    {
        public void Teste() { Console.WriteLine("C::Teste()"); }
    }
}
