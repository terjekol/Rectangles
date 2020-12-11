using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangles
{
    class Rectangle
    {
        private int _x;
        private int _y;
        private int _width;
        private int _height;
        private ConsoleColor _color;

        public Rectangle(int x, int y, int width, int height, ConsoleColor color)
        {
            _color = color;
            _height = height;
            _width = width;
            _y = y;
            _x = x;
        }

        public void Draw()
        {
            for (var y = _y; y < _y + _height; y++)
            {
                DrawLine(_x, y, _width, _color);
            }
        }

        public void Move(Point movement)
        {
            _x += movement.X;
            _y += movement.Y;
        }

        private static void DrawLine(int startX, int y, int width, ConsoleColor color)
        {
            for (var x = startX; x < startX + width; x++)
            {
                DrawPixel(x, y, color);
            }
        }

        private static void DrawPixel(int x, int y, ConsoleColor color)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.ForegroundColor = color;
            Console.Write("█");
        }
    }
}
