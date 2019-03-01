
namespace PointInRectangle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rectange
    {
        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public Rectange(Point topLeft, Point lowerRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = lowerRight;
        }

        public bool Contains(Point point)
        {
            bool isHorizontal = this.TopLeft.PointX <= point.PointX && this.BottomRight.PointX >= point.PointX;

            bool isInVertical = this.TopLeft.PointY <= point.PointY && this.BottomRight.PointY >= point.PointY;

            bool isInRectangle = isHorizontal && isInVertical;

            return isInRectangle;
        }
    }
}
