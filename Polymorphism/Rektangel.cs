using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Rektangel : Teckning
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Rektangel() : this(0,0) { }
        public Rektangel(double b, double h)
        {
            this.Base = b;
            this.Height = h;
            Base = 1.3d;
            Height = 3.1d;
        }

        public override double Area()
        {
            area = this.Base * this.Height;
            Console.WriteLine("Area Rektangel: {0}", area);
            return area;
        }
    }
}
