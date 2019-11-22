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
        private List<Point3D> Corners;
        public Polygon Polygon { get; private set; }

        public Face(params Point3D[] corners)
        {
            if(corners.Length < 3)
            {
                throw new ArgumentException("Error in " + ToString() + " not enough corner. There must be atleast 3 corners");
            }
            else
            {
                Corners = new List<Point3D>(corners);
            }
            GeneratePolygon();
        }
        private void GeneratePolygon()
        {
            Polygon = new Polygon
            {
                Points = new PointCollection(new Func<IEnumerable<Point>>(() => {
                    var pc = new List<Point>();
                    foreach (Point3D corner in Corners)
                    {
                        pc.Add(new Point(corner.X, corner.Y));
                    }
                    return pc;
                }).Invoke()),
                Stroke = new SolidColorBrush(Colors.Black),
                StrokeThickness = 3
            };
        }
    }
}
