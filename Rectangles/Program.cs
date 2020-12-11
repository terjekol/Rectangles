using System;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(3, 4, 10, 2, ConsoleColor.Green);
            do
            {
                Console.Clear();
                rectangle.Draw();
                var keyInfo = Console.ReadKey();
                var p = Point.PointFromKey(keyInfo);
                rectangle.Move(p);
            } while (true);
        }
    }
}
