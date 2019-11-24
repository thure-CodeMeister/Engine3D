using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine3D
{
    class CList<T> : List<T> where T : ICloneable
    {
        public object Clone() {
            var shallowCopy = new CList<T>();

            foreach(T t in this) {
                shallowCopy.Add((T)t.Clone());
            }

            return shallowCopy;
        }
    }
}
