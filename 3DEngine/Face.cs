using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace Engine3D
{
    class Face
    {
        private List<Point3D> cornersActual;
        public List<Point3D> CornersScaled { get; private set; }
        public Polygon Polygon { get; private set; }


        public void ScalePolygon() {
            for(int i = 0; i < cornersActual.Count; i++) {
                Point3D point = cornersActual[i];
                
                double zSpan = Horizon.VanishingPoint.Z - point.Z;
                double xPerZ = zSpan / (Horizon.VanishingPoint.X - point.X);
                double yPerZ = zSpan / (Horizon.VanishingPoint.Y - point.Y);

                double xScaled = xPerZ * point.Z;
                double yScaled = yPerZ * point.Z;

                if(xScaled != CornersScaled[i].X || yScaled != CornersScaled[i].Y) {
                    CornersScaled[i] = new Point3D(xScaled, yScaled, point.Z);
                }
            }
        }

        public Face(params Point3D[] corners) {
            if(corners.Length < 3) {
                throw new ArgumentException("Error in " + ToString() + " not enough corners. There must be at least 3 corners");
            } else {
                Polygon = new Polygon() {
                    StrokeThickness = 3,
                    Stroke = new SolidColorBrush(Colors.Black)
                };
                cornersActual = corners.ToList();
                CornersScaled = new List<Point3D>();
                foreach(Point3D corner in this.cornersActual) {
                    CornersScaled.Add((Point3D)corner.Clone());
                }
            }
            GeneratePolygon();
        }
        private void GeneratePolygon() {
            Polygon.Points = new PointCollection(new Func<IEnumerable<Point>>(() => {
                var pc = new List<Point>();
                foreach(Point3D corner in cornersActual) {
                    pc.Add(new Point(corner.X, corner.Y));
                }
                return pc;
            }).Invoke());
        }
    }
}
