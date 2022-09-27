using System;

namespace Polimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Teste();     // saída --> "A::Teste()"
            b.Teste();     // saída --> "B::Teste()"
            c.Teste();     // saída --> "C::Teste()"

            a = new B();
            a.Teste();     // saída --> "A::Teste()"

            b = new C();
            b.Teste();     // saída --> "B::Teste()"

            Console.ReadKey();
        }
    }
    public class A
    {
        public void Teste() { Console.WriteLine("A::Teste()"); }
    }

    public class B : A
    {
        public new void Teste() { Console.WriteLine("B::Teste()"); }
    }

    public class C : B
    {
        public new void Teste() { Console.WriteLine("C::Teste()"); }
    }
}
