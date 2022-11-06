using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClassDiagram
{
    internal class Rectangle : Shape
    {
        protected double side1 , side2 ;    
        public Rectangle(double x, double y) : base(x, y)
        {
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Parametar()
        {
            return 2 * (side1 + side2);
        }
    }
}
