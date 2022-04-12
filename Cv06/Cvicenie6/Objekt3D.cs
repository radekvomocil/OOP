using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie6
{
    abstract class Objekt3D : GrObjekt
    {
        public abstract double CalcSurface();
        public abstract double CountExtend();
    }
}
