using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Rectangle : Shape
    {
        private float width;
        private float height;

       public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override float Area()
        {
            return  width * height;
        }

        public override float Perimeter()
        {
            return (width+height)*2;
        }
    }
}
