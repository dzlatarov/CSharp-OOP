
namespace PointInRectangle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Point
    {
        public int PointX { get; set; } = 0;

        public int PointY { get; set; } = 0;

        public Point(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }
    }
}
