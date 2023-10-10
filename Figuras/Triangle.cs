using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Triangle : Shape
    {
        private float Side;

        public Triangle(float Side)
        {
            this.Side = Side;
        }

        public override float Area()
        {
            return Side*Side/2;
        }

        public override float Perimeter()
        {
            return Side * 3;
        }
    }
}
