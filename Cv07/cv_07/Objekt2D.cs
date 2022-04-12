using System;
using System.Collections.Generic;
using System.Text;

namespace Cvicenie7
{
    public abstract class Objekt2D : I2D, IComparable
    {
        public int CompareTo(object obj)
        {
            if (((Objekt2D)obj).Surface() > this.Surface())
                return 0;
            else
                return 1;
        }
        public abstract double Surface();
    }
}
 