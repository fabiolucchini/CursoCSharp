using System;

namespace Polimorfismo4
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Teste(); // saida --> "A::Teste()"
            b.Teste(); // saida --> "B::Teste()"
            c.Teste(); // saida --> "C::Teste()"

            a = new B();
            a.Teste(); // saida --> "A::Test()"

            b = new C();
            b.Teste(); // saida --> "C::Teste()"

            Console.ReadKey();
        }
    }
    class A
    {
        public void Teste() { Console.WriteLine("A::Teste()"); }
    }

    class B : A
    {
        public new virtual void Teste() { Console.WriteLine("B::Teste()"); }
    }

    class C : B
    {
        public override void Teste() { Console.WriteLine("C::Teste()"); }
    }
}
