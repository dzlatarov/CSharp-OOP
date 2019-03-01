
namespace PointInRectangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PointInRectangle
    {
        public static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Point topLeftPoint = new Point(coordinates[0], coordinates[1]);
            Point bottomRightPoint = new Point(coordinates[2],coordinates[3]);
            Rectange rectangle = new Rectange(topLeftPoint, bottomRightPoint);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] inputCoords = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Point currentPoint = new Point(inputCoords[0], inputCoords[1]);
                
                Console.WriteLine(rectangle.Contains(currentPoint));
            }
        }
    }
}
