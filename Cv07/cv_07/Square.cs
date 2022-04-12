using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie7
{
    public class Square : Objekt2D
    {
        private int x;
        public Square(int x) {
            this.x = x;
        }

        public override double Surface() {
            return x * x;
        }
        public override String ToString() {
            return String.Format("Surface of square: " + Surface());
        }
    }
}
