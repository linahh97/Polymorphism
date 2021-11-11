using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Teckning
    {
        public double area;

        public virtual double Area()
        {
            return area;
        }
    }
}
