using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> quadOverlayMap = new Dictionary<int, int>();       //每个四边形与其它四边形相交的次数
            int count = 10000;
            Quad[] quads = new Quad[count];
            var random = new Random(new Guid().GetHashCode());
            for (int i = 0; i < count; i++)
            {
                var bl = new Point(random.Next(-1000, -10), random.Next(-1000, -10));
                var tr = new Point(bl.x + 100, bl.y + 100);
                quads[i] = new Quad(bl, tr);
            }
            for (int i = 0; i < count - 1; i++)
            {
                var quad = quads[i];
                for (int j = i + 1; j < count; j++)
                {
                    if(Quad.Intersect(quad, quads[j]))
                    {
                        if(quadOverlayMap.ContainsKey(i))
                        {
                            quadOverlayMap[i] += 1;
                        }
                        else
                        {
                            quadOverlayMap.Add(i, 1);
                        }
                    }
                }

                if (quadOverlayMap.ContainsKey(i))
                    Console.WriteLine("与第{0}个四边形相交的四边形数量为：{1}", i, quadOverlayMap[i]);
            }
            Console.ReadKey();
        }
    }
}
