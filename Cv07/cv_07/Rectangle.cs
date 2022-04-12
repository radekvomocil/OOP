using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie7
{
    public class Rectangle : Objekt2D
    {
        private int x;
        private int y;

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override double Surface()
        {
            return y * x;
        }

        public override String ToString()
        {
            return String.Format("Surface of rectangle: " + Surface());
        }
    }
}
