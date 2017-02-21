using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisestrukoNaslijeđivanje
{
    interface IA
    {
        void PrintA();
    }
    class A : IA
    {
        public void PrintA()
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void PrintB();
    }
    class B : IB
    {
        public void PrintB()
        {
            Console.WriteLine("B");
        }
    }
    class AB : IA,IB
    {
        A a = new A();
        B b = new B();

        public void PrintA()
        {
            a.PrintA();
        }
        public void PrintB()
        {
            b.PrintB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.PrintA();
            ab.PrintB();
        }
    }
}
