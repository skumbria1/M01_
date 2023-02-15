using System;

namespace RectangleHelper
{
    public class RectangleCalculation
    {
        public static int Perimeter(int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                return 0;
            }
            return width * 2 + height * 2;
        }

        public static int Square(int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                return 0;
            }
            return width * height;
        }
    }
}
