using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3D
{
    class Horizon
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y { get; set; }
        public double Z { get; private set; }
        public Point3D VanishingPoint { get; private set; }
        public Horizon(double x1, double x2, double y, double z)
        {
            X1 = x1;
            X2 = x2;
            Y = y;
            Z = z;
            VanishingPoint = new Point3D(x2 / 2, Y, Z);
        }
    }
}
