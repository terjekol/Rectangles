using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangles
{
    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point PointFromKey(ConsoleKeyInfo keyInfo)
        {
            Point p = new Point(0, 0);
            if (keyInfo.Key == ConsoleKey.LeftArrow) p = new Point(-1, 0);
            else if (keyInfo.Key == ConsoleKey.RightArrow) p = new Point(1, 0);
            else if (keyInfo.Key == ConsoleKey.UpArrow) p = new Point(0, -1);
            else if (keyInfo.Key == ConsoleKey.DownArrow) p = new Point(0, 1);
            return p;
        }
    }
}
