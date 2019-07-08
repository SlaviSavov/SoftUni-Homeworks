using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangleCoordinate = ParseInput();

            Point leftTop = new Point(rectangleCoordinate[0], rectangleCoordinate[1]);
            Point bottomRight = new Point(rectangleCoordinate[2], rectangleCoordinate[3]);

            Rectangle rectangle = new Rectangle(leftTop, bottomRight);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputCoordinate = ParseInput();

                Point point = new Point(inputCoordinate[0], inputCoordinate[1]);

                Console.WriteLine(rectangle.Contains(point));
            }

        }

        private static int[] ParseInput()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
