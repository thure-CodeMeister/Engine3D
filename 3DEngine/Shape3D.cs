using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Engine3D
{
    class Shape3D
    {
        List<Face> Faces;

        public Shape3D(params Face[] faces)
        {
            Faces = new List<Face>();

            foreach (Face face in faces)
            {
                Faces.Add(face);
            }
        }
    }
}
