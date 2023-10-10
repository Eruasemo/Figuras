using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Circle : Shape
    {
        private float radius;
        public float Diameter
        {
            get { return radius*2; }
        }
        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float Area()
        {
            return (float) (Math.PI * Math.Pow(radius,2));
        }

        public override float Perimeter()
        {
            return (float)Math.PI * Diameter;
        }
    }
}
