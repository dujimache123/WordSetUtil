using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    //四边形类
    class Quad
    {
        public Point bottomLeft;
        public Point topLeft;
        public Point topRight;
        public Point bottomRight;

        //提供左下角、右上角2点构造形式
        public Quad(Point bl, Point tr)
        {
            this.bottomLeft = bl;
            this.topRight = tr;
            this.topLeft = new Point(bl.x, tr.y);
            this.bottomRight = new Point(tr.x, bl.y);
        }

        //判断点是否在四边形内
        public static bool IsPointInQuad(Point p, Quad quad)
        {
            if (p.x >= quad.bottomLeft.x && p.x <= quad.topRight.x && p.y >= quad.bottomLeft.y && p.y <= quad.topRight.y)
                return true;
            return false;
        }

        public static bool Intersect(Quad a, Quad b)
        {
            return IsPointInQuad(a.bottomLeft, b) ||
                IsPointInQuad(a.topLeft, b) ||
                IsPointInQuad(a.topRight, b) ||
                IsPointInQuad(a.bottomRight, b) ||
                IsPointInQuad(b.bottomLeft, a) ||
                IsPointInQuad(b.topLeft, a) ||
                IsPointInQuad(b.topRight, a) ||
                IsPointInQuad(b.bottomRight, a);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", bottomLeft.ToString(), topLeft.ToString(), topRight.ToString(), bottomRight.ToString());
        }
    }
}
