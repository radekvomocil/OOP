using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie7
{
    public class Circle : Objekt2D
    {
        private int r;

        public Circle(int r)
        {
            this.r = r;
            Surface();
        }

        public override double Surface()
        {
            return 2*Math.PI*r;
        }
        public override String ToString()
        {
            return String.Format("Surface of circle: " + Surface());
        }
    }
}
