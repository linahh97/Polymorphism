using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckning R = new Rektangel();
            R.Area();
            Teckning C = new Cirkel();
            C.Area();
            Teckning F = new Fyrkant();
            F.Area();
            Console.ReadKey();
        }
    }
}
