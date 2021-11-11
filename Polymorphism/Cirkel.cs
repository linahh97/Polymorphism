using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Cirkel : Teckning
    {
        public double pi = 3.1415d;
        public double Radius { get; set; }

        public Cirkel() : this(0) { }
        public Cirkel(double r)
        {
            this.Radius = r;
            Radius = 2.4d;
        }
        public override double Area()
        {
            area = this.Radius * this.Radius * pi;
            Console.WriteLine("Area Cirkel: {0}", area);
            return area;
        }
    }
}
