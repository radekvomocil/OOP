using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie7
{
    public class Ellispe : Objekt2D
    {
        private int r;

        public Ellispe(int r)
        {
            this.r = r;
        }

        public override double Surface()
        {
            return 2 * Math.PI * r;
        }

        public override String ToString()
        {
            return String.Format("Surface of ellipse: " + Surface());
        }
    }
}
