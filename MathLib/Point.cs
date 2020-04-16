using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    class Point
    {
        public float x;
        public float y;
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", x, y);
        }
    }
}
