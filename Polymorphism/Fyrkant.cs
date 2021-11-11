using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Fyrkant : Teckning
    {
        public double Base { get; set; }

        public Fyrkant() : this(0) { }
        public Fyrkant(double b)
        {
            this.Base = b;
            Base = 4.8d;
        }
        public override double Area()
        {
            area = this.Base * this.Base;
            Console.WriteLine("Area Kvadrat: {0}", area);
            return area;
        }
    }
}
