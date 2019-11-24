using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3D
{
    static class Horizon
    {
        static public double X1 { get; set; }
        static public double X2 { get; set; }
        static public double Y { get; set; }
        static public double Z { get; private set; }
        static public Point3D VanishingPoint { get; private set; }
        static public void SetHorizon(double x1, double x2, double y, double z) {
            X1 = x1;
            X2 = x2;
            Y = y;
            Z = z;
            VanishingPoint = new Point3D(x2 / 2, Y, Z);
        }
    }
}
