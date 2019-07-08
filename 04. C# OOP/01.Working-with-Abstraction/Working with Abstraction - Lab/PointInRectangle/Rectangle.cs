using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft,Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public bool Contains(Point point)
        {
            bool insideByX = point.X >= TopLeft.X 
                && point.X <= BottomRight.X;

            bool insideByY = point.Y >= TopLeft.Y
                && point.Y <= BottomRight.Y;

            return insideByX && insideByY;
        }
    }
}
